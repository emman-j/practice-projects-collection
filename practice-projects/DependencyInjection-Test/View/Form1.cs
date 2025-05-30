using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DITest
{
    public partial class Form1 : Form
    {
        private readonly Model.IUserService _userService;
        //private readonly Model.User _user;
        private readonly Presenter.User _userPresenter;
        private readonly IServiceProvider _serviceProvider;
        private readonly MyClass _myClass;

        public Form1()
        {
            InitializeComponent();
            _serviceProvider = Global.ServiceLocator.ServiceProvider;

            _userService = _serviceProvider.GetService<Model.IUserService>();
            //_user = _serviceProvider.GetService<Model.User>();
            _userPresenter = _serviceProvider.GetService<Presenter.User>();
            _myClass = _serviceProvider.GetService<MyClass>();

            _userService.UserName = "Juan";
            _userPresenter.UserName = _userService.UserName;

            label1.DataBindings.Add("Text", _userPresenter, nameof(_userPresenter.UserName));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_userService.UserName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender; 
            _userPresenter.UserName = textBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _myClass.DoSomething();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using (Form2 dialogueForm = new Form2(_serviceProvider))
            //{
            //    if (dialogueForm.ShowDialog() == DialogResult.OK)
            //    {

            //    }
            //}

            Form2 f2 = new Form2(_serviceProvider);
            //this.Hide();
            f2.Show();
        }

    }
}
