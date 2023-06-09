using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ListEmployee
    {
        private static ListEmployee anInstance;
        private List<Employee> listEmployees;

        internal static ListEmployee AnInstance
        { 
            get
            {
                if (anInstance == null)
                    anInstance = new ListEmployee();
                return anInstance;
            }
                
            
            
            set => anInstance = value; 
        }
        public List<Employee> ListEmployees { get => listEmployees; set => listEmployees = value; }

        public ListEmployee()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee("100", "l1", "Nguyễn Văn Nghĩa", "10/05/1999", "Nam", "Bắc Ninh", "0986457123", "nghia@gmail.com", "1259345667", "Thạc sĩ", "Tech Lead", "Kỹ Thuật", "1000 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("101", "l1", "Trần Thị Hương", "15/09/1995", "Nữ", "Hải Phòng", "0978123456", "huong@gmail.com", "987654321", "Tiến sĩ", "Phó Giám Đốc", "Quản Lý", "2000 USD", "Tốt"));
            listEmployees.Add(new Employee("102", "l2", "Ngô Minh Tuấn", "20/12/1990", "Nam", "Hồ Chí Minh", "0967123456", "tuan@gmail.com", "135792468", "Thạc sĩ", "Kỹ Sư Phần Mềm", "Công Nghệ", "1500 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("103", "l3", "Lê Thị Mai", "03/06/1993", "Nữ", "Đà Nẵng", "0918234567", "mai@gmail.com", "246813579", "Thạc sĩ", "Quản Lý Dự Án", "Quản Lý", "1800 USD", "Tốt"));
            listEmployees.Add(new Employee("104", "l4", "Phạm Văn Long", "12/08/1988", "Nam", "Hải Dương", "0947654321", "long@gmail.com", "357951246", "Tiến sĩ", "Giám Đốc Kỹ Thuật", "Kỹ Thuật", "2500 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("105", "l5", "Đỗ Thị Thu", "28/02/1992", "Nữ", "Huế", "0923456789", "thu@gmail.com", "468135792", "Thạc sĩ", "Chuyên Viên Tư Vấn", "Tư Vấn", "1200 USD", "Khá"));
            listEmployees.Add(new Employee("106", "l6", "Vũ Đức Anh", "05/11/1996", "Nam", "Hải Phòng", "0934567890", "anh@gmail.com", "579246813", "Cử nhân", "Kỹ Sư Phần Mềm", "Công Nghệ", "1400 USD", "Tốt"));
            listEmployees.Add(new Employee("107", "l7", "Hoàng Thị Hoa", "19/04/1994", "Nữ", "Hà Nội", "0912345678", "hoa@gmail.com", "682357914", "Thạc sĩ", "Quản Lý Nhân Sự", "Quản Lý", "2000 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("108", "l8", "Trương Văn Minh", "22/10/1991", "Nam", "Thái Bình", "0945678912", "minh@gmail.com", "793468125", "Cử nhân", "Kỹ Sư Công Trình", "Xây Dựng", "1700 USD", "Khá"));
            listEmployees.Add(new Employee("109", "l9", "Nguyễn Thị Hạnh", "08/07/1993", "Nữ", "Quảng Nam", "0967891234", "hanh@gmail.com", "468125793", "Thạc sĩ", "Chuyên Viên Kinh Doanh", "Kinh Doanh", "1600 USD", "Tốt"));
            listEmployees.Add(new Employee("110", "l10", "Lê Văn Đức", "17/12/1990", "Nam", "Vĩnh Long", "0978912345", "duc@gmail.com", "579314682", "Cử nhân", "Kiểm Soát Chất Lượng", "Kiểm Soát Chất Lượng", "1900 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("111", "l11", "Nguyễn Thị Thuỷ", "29/09/1994", "Nữ", "Bình Định", "0981234567", "thuy@gmail.com", "682457931", "Thạc sĩ", "Nhà Quản Lý Dự Án", "Quản Lý", "2000 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("112", "l12", "Trần Văn Nam", "09/03/1991", "Nam", "Cà Mau", "0912345678", "nam@gmail.com", "793146825", "Cử nhân", "Nhân Viên Kỹ Thuật", "Kỹ Thuật", "1400 USD", "Tốt"));
            listEmployees.Add(new Employee("113", "l13", "Lê Thị Thanh", "15/08/1995", "Nữ", "Đắk Lắk", "0923456789", "thanh@gmail.com", "468257931", "Tiến sĩ", "Giảng Viên Đại Học", "Giảng Dạy", "2200 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("114", "l14", "Phạm Văn Thắng", "25/01/1992", "Nam", "Bình Thuận", "0934567890", "thang@gmail.com", "579314682", "Cử nhân", "Nhân Viên Kỹ Thuật", "Kỹ Thuật", "1500 USD", "Tốt"));
            listEmployees.Add(new Employee("115", "l15", "Nguyễn Thị Trúc", "05/06/1996", "Nữ", "Lâm Đồng", "0945678912", "truc@gmail.com", "682579314", "Thạc sĩ", "Kỹ Sư Phần Mềm", "Công Nghệ", "1600 USD", "Tốt"));
            listEmployees.Add(new Employee("116", "l16", "Phạm Văn Hoàng", "10/11/1993", "Nam", "Đồng Nai", "0956789123", "hoang@gmail.com", "791346825", "Thạc sĩ", "Nhân Viên Kinh Doanh", "Kinh Doanh", "1800 USD", "Tốt"));
            listEmployees.Add(new Employee("117", "l17", "Đỗ Thị Hà", "21/04/1991", "Nữ", "Phú Yên", "0967891234", "ha@gmail.com", "468125793", "Cử nhân", "Nhân Viên Kỹ Thuật", "Kỹ Thuật", "1400 USD", "Tốt"));
            listEmployees.Add(new Employee("118", "l18", "Nguyễn Văn Đức", "02/09/1994", "Nam", "Thừa Thiên Huế", "0978912345", "duc@gmail.com", "579314682", "Thạc sĩ", "Nhà Quản Lý Dự Án", "Quản Lý", "2000 USD", "Xuất sắc"));
            listEmployees.Add(new Employee("119", "l19", "Trần Thị Hồng", "13/05/1992", "Nữ", "Bình Phước", "0981234567", "hong@gmail.com", "682457931", "Cử nhân", "Chuyên Viên Kinh Doanh", "Kinh Doanh", "1600 USD", "Tốt"));
            listEmployees.Add(new Employee("120", "l20", "Vũ Văn An", "26/02/1996", "Nam", "Bà Rịa - Vũng Tàu", "0992345678", "an@gmail.com", "791346825", "Thạc sĩ", "Kỹ Sư Phần Mềm", "Công Nghệ", "1400 USD", "Tốt"));
        }
    }
}
