using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20180140067
{
    //Perhatikan catatan 'NOTE' dibawah ini
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
                //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                // secara default
                // throw new Exception(ex.Message)
                // pesan error secara default
                // throw new faultException("Pesan Salah");
                // untuk melambangkan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
                //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                // secara default
                // throw new Exception(ex.Message)
                // pesan error secara default
                // throw new faultException("Pesan Salah");
                // untuk melambangkan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
                //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                // secara default
                // throw new Exception(ex.Message)
                // pesan error secara default
                // throw new faultException("Pesan Salah");
                // untuk melambangkan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
                //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                // secara default
                // throw new Exception(ex.Message)
                // pesan error secara default
                // throw new faultException("Pesan Salah");
                // untuk melambangkan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        //TKoordinat:nama methodnya, a,b = input seperti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya 
        //dengan yb lalu dimasukkan ke hasil
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
                //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                // secara default
                // throw new Exception(ex.Message)
                // pesan error secara default
                // throw new faultException("Pesan Salah");
                // untuk melambangkan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}
