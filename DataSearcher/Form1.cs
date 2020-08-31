using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft.Document;

namespace DataSearcher
{
    public partial class Form1 : Form
    {

       
        private static string search_txt = "";//this will be filled by the user's input keyword
        private static string searchPath = ".\\Data Source";//the default searching path is the path where the software is installed and ex , default_search_path = "C:\\Program Files (x86)\\Meku Search\\New folder"
        const string label_files_containing_txt = "Files Containing Keyword";

        public Form1()
        {
            InitializeComponent();

            this.txt_directory.Text = searchPath;

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            var dir = new FolderBrowserDialog();
            dir.SelectedPath = this.txt_directory.Text;

            if (dir.ShowDialog(this) == DialogResult.OK)
            {
                searchPath = dir.SelectedPath;
                this.txt_directory.Text = searchPath;

            }

        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            search_txt = this.txt_Keyword.Text.ToString();
            list_files_containing_keyword();

        }

        

     
        private void listview1_ItemActivate(object sender, EventArgs et)
        {
            
            display_specific_paragraph(sender);

        }
        



        private void list_files_containing_keyword()
        {
            this.listView1.Items.Clear();
            this.textBox_result.Clear();


            DirectoryInfo searchDir = new DirectoryInfo( searchPath );
            List<string> files_to_be_searched = new List<string>();


            /////the code from line 83 to line 90 can be skipped if want to use only one data source folder
            /// and contains only .docx and .pdf files. But if u use the "Browse" button and a user can change the source
            /// folder then the program needs to select those files which are .docx and .pdf

            //// selecting files with extension .docx and .pdf including child directories
            foreach (string file in Directory.GetFiles(searchDir.FullName, "*.*", SearchOption.AllDirectories))
            {
                string ext = Path.GetExtension(file).ToLower();
           
                //selecting files with extensions .docx and .pdf 
                files_to_be_searched.Add(file);
                
            }

            ////setting things up for the next move 
            int totalFiles = 0, totalMatches = 0, containing_files = 0;

            //doing the doing 
            foreach (string file in files_to_be_searched)  
            {

                int paragraph_matches = 0, keyword_matches = 0;

                DocumentCore dc = DocumentCore.Load(file);

                totalFiles++; //increasing the number of searchred files by 1


                //counting the number of times the keyword is found in the doc file
                keyword_matches = dc.Content.Find(search_txt).Count();

                //if keyword not found continue loop for another file
                    if ( keyword_matches <= 0)
                {
                    continue;  
                }

                else
                {
                    containing_files++;//increasing the number of files containing the keyword
                    /*
                     * to show the number of paragraphs the key word was found in
                     */

                    
                    Section section = dc.Sections[0];
                    for (int i = 0; i < section.Blocks.Count; i++)
                    {

                        //counting the number of time the key word is found in a paragraph
                        int j = section.Blocks[i].Content.Find(search_txt).Count();
                        if (j > 0)
                        {

                            paragraph_matches++; 
                           
                        }

                    }
                 


                    totalMatches += keyword_matches;

                    var fileinfo = new FileInfo(file);      
                    this.listView1.Items.Add(new ListViewItem(new string[] { containing_files.ToString(), fileinfo.Name, string.Format("{0:0.0d}", fileinfo.Length / 1024d + "kb"), keyword_matches.ToString() + " matches in " + paragraph_matches+ " paragraphs." }));

                    ////////   files_to_be_searched.Count + "files scanned" ///////

                }
            }

            //changing the header of the listview with the no of files contaning the keyword;
            this.label_containg_files.Text = containing_files + " "+label_files_containing_txt + " \""+search_txt+"\"" ;

            //this is the message show after the searching is complete
             MessageBox.Show(" A total of " + files_to_be_searched.Count + " files scanned ");
  

        }

        private void display_specific_paragraph(object sender )
        {
        
            textBox_result.Clear();
       

            string result = "",section_info = "";

            DirectoryInfo searchDir = new DirectoryInfo(searchPath);

            string filePath = searchDir.FullName +"\\"+
                        ((ListView)sender).SelectedItems[0].SubItems[1].Text.ToString();
            
         

            

            if ( File.Exists(filePath) )
            {
                
                DocumentCore dc = DocumentCore.Load( filePath );
                int paragraph_no = 0;


               

                Section section = dc.Sections[0];
                
                for (int i = 0; i < section.Blocks.Count; i++)//searching in each section of the .docx file
                {
                    
                    int keyword_matches = section.Blocks[i].Content.Find(search_txt.ToString()).Count();
          
                    if ( keyword_matches > 0)
                    {
                        
                        textBox_result.AppendText(Environment.NewLine);
                        textBox_result.AppendText(" PARAGRAPH  " + ++paragraph_no + ". \t" + keyword_matches + " \"" + search_txt +"\"s  found! ");
                        textBox_result.AppendText(Environment.NewLine);


                        textBox_result.AppendText(section.Blocks[i].Content.ToString());
                        textBox_result.AppendText(Environment.NewLine);


                        textBox_result.AppendText("_________________________________");
                       


                    }

                    
                    
                }


                if (paragraph_no == 0)
                {
                    if (File.Exists(filePath))
                        Process.Start(filePath); // if the file can't be opened by our program open it using microsoft word processer
                                                 // please try to make the program able to open any file. 
                                                 // u can achieve this by improving the code from line 179 to 204 (the code trys to check all sections if the keyword is present
                                                 // and if it finds one it will increase the "paragraph_no" variable, if no paragraph has the key word then that means 
                                                 // we are going to open with microsoft word. So search (on the internet) how to find a certain keyword from a .docx file's paragraph by paragraph
                                                 
                }

            }

            else
            {
                textBox_result.Text = filePath+"not found!";
              
            }
            
           
           
        }
       

                /// not important generated by .net
        

        private void txtBox_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveSearchedKeyWordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
            /// not important

    }
}


