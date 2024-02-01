
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace PublishingHousedop2
{
    public partial class Form1 : Form
    {
        private readonly PublishingHouseContext dbContext;
        private TabControl tabControl;
        private DataGridView booksDataGridView;
        private DataGridView authorsDataGridView;
        private DataGridView publishersDataGridView;
        public Form1()
        {
            InitializeComponent();
            tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;


            TabPage booksTabPage = new TabPage("Books");
            booksDataGridView = new DataGridView();
            booksDataGridView.Dock = DockStyle.Fill;
            booksTabPage.Controls.Add(booksDataGridView);
            tabControl.TabPages.Add(booksTabPage);

            TabPage authorsTabPage = new TabPage("Authors");
            authorsDataGridView = new DataGridView();
            authorsDataGridView.Dock = DockStyle.Fill;
            authorsTabPage.Controls.Add(authorsDataGridView);
            tabControl.TabPages.Add(authorsTabPage);


            TabPage publishersTabPage = new TabPage("Publishers");
            publishersDataGridView = new DataGridView();
            publishersDataGridView.Dock = DockStyle.Fill;
            publishersTabPage.Controls.Add(publishersDataGridView);
            tabControl.TabPages.Add(publishersTabPage);


            this.Controls.Add(tabControl);
            dbContext = new PublishingHouseContext();
            LoadBooksData();
            LoadAuthorsData();
            LoadPublishersData();
        }
        private void LoadBooksData()
        {
           
            var books = dbContext.Books.ToList();
            booksDataGridView.DataSource = books;
        }
        private void LoadAuthorsData()
        {
            TabPage authorsTabPage = tabControl.TabPages["Authors"];
            var authors = dbContext.Authors.ToList();
            
            authorsDataGridView.DataSource = authors;
        }
        private void LoadPublishersData()
        {
            TabPage publishersTabPage = tabControl.TabPages["Publishers"];
            
            var publishers = dbContext.Publishers.ToList();
           
            publishersDataGridView.DataSource = publishers;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            DialogResult result = authorForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Author newAuthor = authorForm.GetAuthorData();
                dbContext.Authors.Add(newAuthor);
                dbContext.SaveChanges();
                LoadAuthorsData();
            }
        }

        private void EditAuthorButton_Click_1(object sender, EventArgs e)
        {
            if (authorsDataGridView.SelectedRows.Count > 0)
            {
                Author selectedAuthor = (Author)authorsDataGridView.SelectedRows[0].DataBoundItem;
                AuthorForm authorForm = new AuthorForm(selectedAuthor);
                DialogResult result = authorForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Author editedAuthor = authorForm.GetAuthorData();
                    Author existingAuthor = dbContext.Authors.Find(editedAuthor.Id);
                    if (existingAuthor != null)
                    {
                        dbContext.Entry(existingAuthor).CurrentValues.SetValues(editedAuthor);
                        dbContext.SaveChanges();
                        LoadAuthorsData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите автора для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            if (authorsDataGridView.SelectedRows.Count > 0) 
            {
                Author selectedAuthor = (Author)authorsDataGridView.SelectedRows[0].DataBoundItem;
                dbContext.Authors.Remove(selectedAuthor);
                dbContext.SaveChanges();
                LoadAuthorsData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите автора для удаления.");
            }
        }
    }
}