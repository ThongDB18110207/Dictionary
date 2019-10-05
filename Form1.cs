using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void loadLabelWord()
        {
            Label lb_Word = new Label();
            lb_Word.Text = tbx_Nhaptu.Text;
            this.Controls.Add(lb_Word);
            lb_Word.BackColor = Color.White;
            lb_Word.Top = tbx_Nhaptu.Top + 100;
            lb_Word.Left = tbx_Nhaptu.Left - 100;
            lb_Word.Width = tbx_Nhaptu.Width + 300;
            lb_Word.Height = 40;
        }

        void loadLableWordType()
        {
            Label lb_WordType = new Label();
            lb_WordType.Text = "Noun";
            this.Controls.Add(lb_WordType);
            lb_WordType.BackColor = Color.White;
            lb_WordType.Top = tbx_Nhaptu.Top + 140;
            lb_WordType.Left = tbx_Nhaptu.Left - 100;
            lb_WordType.Width = tbx_Nhaptu.Width + 300;
            lb_WordType.Height = 40;
        }

        void loadLableMean()
        {
            Label lb_Mean = new Label();
            lb_Mean.Text = "Quả táo";
            this.Controls.Add(lb_Mean);
            lb_Mean.BackColor = Color.White;
            lb_Mean.Top = tbx_Nhaptu.Top + 180;
            lb_Mean.Left = tbx_Nhaptu.Left - 100;
            lb_Mean.Width = tbx_Nhaptu.Width + 300;
            lb_Mean.Height = 40;
          
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            loadLabelWord();
            loadLableWordType();
            loadLableMean();
        }
    }
    
}
