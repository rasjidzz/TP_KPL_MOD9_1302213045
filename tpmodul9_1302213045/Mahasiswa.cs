using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace tpmodul9_1302213045
{
    public class Mahasiswa
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public Mahasiswa(string nama, string nim) { 
            this.Nama = nama; 
            this.Nim = nim; 
        }
    }

}