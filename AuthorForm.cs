using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingHousedop2
{
    public partial class AuthorForm : Form
    {
        public string AuthorName { get; private set; }
        public AuthorForm()
        {
            InitializeComponent();
        }
        public AuthorForm(Author author)
        {
            InitializeComponent();
            AuthorNameTextBox.Text = author.Name;
        }
        public Author GetAuthorData()
        {
            return new Author
            {
                Name = AuthorName
            };
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthorNameTextBox.Text))
            {
                MessageBox.Show("Введите имя автора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AuthorName = AuthorNameTextBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}