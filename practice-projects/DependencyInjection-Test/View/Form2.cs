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
using static DITest.Model;

namespace DITest
{
    public partial class Form2 : Form
    {   
        private readonly IServiceProvider _serviceProvider;
        private readonly Presenter.User _userPresenter;
        private readonly MyClass _myClass;

        public Form2(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
             
            //_user = _serviceProvider.GetService<Model.User>();
            _userPresenter = _serviceProvider.GetService<Presenter.User>();
            _myClass = _serviceProvider.GetService<MyClass>();

            label1.DataBindings.Add("Text", _userPresenter, nameof(_userPresenter.UserName));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //_myClass.DoSomething(); 
        }
    }
}
