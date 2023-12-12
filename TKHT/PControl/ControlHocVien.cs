using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKHT.DTO;

namespace TKHT.PControl
{
    public class ControlHocVien: ControlDB
    {

        public static IEnumerable<DTOStudent> findAll()
        {
            var aList = db.Students.Select(s => new DTOStudent
            {
                ID = s.id,
                Name = s.Name,
                Address = s.Address,
                Sex = s.Sex,
                Phone = s.Phone,
                ClassName = s.Class.Name,
            }).ToList();

            return aList;
        }

        public static void Add(Student st)
        {
            try
            {
                db.Students.Add(st);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Không thêm được");
            }
        }

        public static void Delete(Student st)
        {
            try
            {
                db.Students.Remove(st);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }

        public static void Update(Student st)
        {
            try
            {
                db.Students.AddOrUpdate(st);
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        public static Student FindSV(string st)
        {
            return db.Students.Find(int.Parse(st));
        }
       
    }
}
