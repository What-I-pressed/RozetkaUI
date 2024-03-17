using Booking.Forms.Category;
using Booking.Forms.Hotel;
using Domain.Entities;
using Helpers;
using Infrastructure.Data;

namespace Booking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            HotelMainForm dlg = new HotelMainForm();
            dlg.ShowDialog();
        }

        private void mHead_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mHead_Options_Seed_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext applicationDbContext = new ApplicationDbContext())
            {
                if (applicationDbContext.Categories.Count() == 0)
                {
                    CategoryEntity tepla_pidloga = new CategoryEntity();
                    tepla_pidloga.Name = "����� ������";
                    tepla_pidloga.Priority = 1;
                    tepla_pidloga.Image = ImageWorker.ImageSaveUrl("https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/products/slideshow_home/img_6521-375x375.jpg", "categories");
                    tepla_pidloga.Description = " ����� ������ Comfort Heat - ������� ������������ ������ " +
                        "������� ������ �� ��������� �����������.";
                    applicationDbContext.Categories.Add(tepla_pidloga);
                    applicationDbContext.SaveChanges();

                    CategoryEntity opalennya = new CategoryEntity();
                    opalennya.Name = "��������";
                    opalennya.Priority = 2;
                    opalennya.Description = "����� ���������� �������� ����� ����������� ������ - " +
                        "���������� ��� ������ ����-���� ��������.";
                    applicationDbContext.Categories.Add(opalennya);
                    applicationDbContext.SaveChanges();

                    #region �������� ������ �������

                    CategoryEntity konvektory = new CategoryEntity();
                    konvektory.ParentId = opalennya.Id;
                    konvektory.Image = ImageWorker.ImageSaveUrl("https://comfortheat.kiev.ua/image/cache/catalog/airelec/airelec-375x375.jpg", "categories");
                    konvektory.Name = "���������� Airelec";
                    konvektory.Priority = 1;
                    konvektory.Description = "��������� ���������� ������ Airelec (�������) - " +
                        "������ � ��������� ������ ��� ��������� ��� ���������� �������� �������� ����-����� ����.";
                    applicationDbContext.Categories.Add(konvektory);
                    applicationDbContext.SaveChanges();

                    CategoryEntity komertsiynoi_neruhomosti = new CategoryEntity();
                    komertsiynoi_neruhomosti.ParentId = opalennya.Id;
                    komertsiynoi_neruhomosti.Priority = 2;
                    komertsiynoi_neruhomosti.Name = "�������� ���������� ����������";
                    komertsiynoi_neruhomosti.Description = "�� ��������� ����������� ������ � ���� Comfort Heat " +
                        "����� ��������� ���������� ������� ������� �������� " +
                        "����-��� ���������� ���������� (��������, �����, ������, ����, ���������, �������� �� ����).";
                    applicationDbContext.Categories.Add(komertsiynoi_neruhomosti);
                    applicationDbContext.SaveChanges();


                    CategoryEntity zhytlovykh_prymishchen = new CategoryEntity();
                    zhytlovykh_prymishchen.ParentId = opalennya.Id;
                    zhytlovykh_prymishchen.Priority = 3;
                    zhytlovykh_prymishchen.Image = ImageWorker.ImageSaveUrl("https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/otoplenie_375_375-375x375.jpg", "categories");
                    zhytlovykh_prymishchen.Name = "�������� �������� ��������";
                    zhytlovykh_prymishchen.Description = "����������� ��������� ����� �������� - ���� � " +
                        "������� �������� ������� �������� ������ ������� ��� ��������. ";
                    applicationDbContext.Categories.Add(zhytlovykh_prymishchen);
                    applicationDbContext.SaveChanges();

                    #endregion

                }
            }
        }

        private void mHead_Opertaion_Category_Click(object sender, EventArgs e)
        {
            CategoryListForm dlg = new CategoryListForm();
            dlg.ShowDialog();
        }
    }
}
