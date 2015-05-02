using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentTestLib;
using TreeLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq.Expressions;
using DinamicLib;

namespace task_12_winform
{
    [Serializable]
    public partial class Form1 : Form
    {
        List<Student> treeList;
        public Form1()
        {
            InitializeComponent();

            FileStream fs = new FileStream("file.s", FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            treeList = (List<Student>)bf.Deserialize(fs);

            fs.Close();

            Object[] ItemObject = new Object[10];
            for (int i = 0; i < 10; i++)
                ItemObject[i] = i + 1;

            comboBoxNumAve.Items.AddRange(ItemObject);
            comboBoxNumSel.Items.AddRange(ItemObject);

            comboBoxVarAve.Items.Add('<');
            comboBoxVarAve.Items.Add('=');
            comboBoxVarAve.Items.Add('>');            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            foreach (Student w in treeList)
            {
                textBox1.Text += w.NameOfStudent + "\t" + w.AverageMarkOfStudent + "\t";
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            IQueryable<Student> queryableData = treeList.AsQueryable<Student>();
            ParameterExpression pe = Expression.Parameter(typeof(Student), "student");            


            if (checkBoxAve.Checked)
            {
                Expression left = Expression.Property(pe, typeof(Student).GetProperty("AverageMarkOfStudent"));
                Expression right = Expression.Constant(double.Parse(comboBoxNumAve.Text), typeof(double));
                Expression eAve;
                if (comboBoxVarAve.Text == ">")
                    eAve = Expression.GreaterThan(left, right);
                else if (comboBoxVarAve.Text == "=")
                    eAve = Expression.Equal(left, right);
                else
                    eAve = Expression.LessThan(left, right);

                queryableData = queryableData.DynamicWhere(Expression.Lambda<Func<Student, bool>>(eAve, new ParameterExpression[] { pe }));

            }

            if (radioButtonSort.Checked)
            {
                queryableData = queryableData.DynamicOrderBy(Expression.Lambda<Func<Student, Student>>(pe, new ParameterExpression[] { pe }));                
            }
            else if (radioButSortDes.Checked)
            {
                queryableData = queryableData.DynamicOrderByDescending(Expression.Lambda<Func<Student, Student>>(pe, new ParameterExpression[] { pe }));
            }

            if (checkBoxSel.Checked)
            {
                queryableData = queryableData.DynamicTake(int.Parse(comboBoxNumSel.Text));                
            }

            foreach (Student student in queryableData)

                textBox2.Text += student.NameOfStudent + "\t" + student.AverageMarkOfStudent + "\t";

        }
    }
}
