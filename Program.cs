using PublishingHousedop2;
using Microsoft.EntityFrameworkCore;
namespace PublishingHousedop2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            using (var dbContext = new PublishingHouseContext())
            {

                // ������� � ��������� �������
                var author3 = new Author { Name = "����� 3" };
                var author4 = new Author { Name = "����� 4" };
                dbContext.Authors.AddRange(author3, author4);

                // ������� � ��������� ���������
                var publisher3 = new Publisher { Name = "������������ 3" };
                var publisher4 = new Publisher { Name = "������������ 4" };
                dbContext.Publishers.AddRange(publisher3, publisher4);
                dbContext.SaveChanges();
                // ������� � ��������� �����, �������� �� � �������� � ����������
                var book1 = new Book { Title = "����� 3", AuthorId = author3.Id, PublisherId = publisher3.Id };
                var book2 = new Book { Title = "����� 4", AuthorId = author4.Id, PublisherId = publisher4.Id };
                dbContext.Books.AddRange(book1, book2);
                dbContext.SaveChanges();
            }
        }
    }
}

