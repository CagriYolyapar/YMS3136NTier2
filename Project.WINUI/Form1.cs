using Project.BLL.DesignPatterns.GenericRepositoryPattern.ConcRep;
using Project.BLL.DesignPatterns.SingeltonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyContext DB;
        private void Form1_Load(object sender, EventArgs e)
        {
            DB = DBTool.DBInstance;
        }
        
        private void btnekle_Click(object sender, EventArgs e)
        {
            
        
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ProductRepository db;
        }
    }
}
