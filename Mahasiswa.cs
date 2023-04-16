namespace tpmodul9_1302213045
{
    public class Mahasiswa
    {
        private String nama { get; set; }
        private String nim { get; set; }

        public Mahasiswa()
        {
            this.nama = null;
            this.nim = null;
        }

        public String Nama
        {
            get { return this.nama; }
            set { this.nama = value; }
        }

        public void printInfo()
        {
            Console.WriteLine(this.nama + " " + this.nim);
        }
    }
}
