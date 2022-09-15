using ADHD;

namespace octor
{

    public class vision
    {

        public static void Main()
        {
            //print out data that their of birth is greater than 06/01/2000
            List<Phora> phora = new List<Phora>();
            phora.Add(new Phora() { ID= 101, Name="madle", Age=15, DOB=12/09/2016, Address="1120,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 102, Name="juble", Age=16, DOB=12/09/2007, Address="1022,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 103, Name="skinku", Age=17, DOB=06/01/2000, Address="1011,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 104, Name="dubdu", Age=18, DOB=12/09/2002, Address="107,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 105, Name="mardel", Age=19, DOB=06/01/2000, Address="210,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 106, Name="morgane", Age=20, DOB=12/09/2002, Address="140,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 107, Name="casper", Age=21, DOB=12/09/2002, Address="140,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 108, Name="banho", Age=22, DOB=06/01/2000, Address="130,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 109, Name="oscar", Age=23, DOB=12/09/2002, Address="102,yusf street Ogunde, texas" });
            phora.Add(new Phora() { ID= 100, Name="moro", Age=24, DOB=12/09/2002, Address="11,yusf street Ogunde, texas" });



            Predicate<Phora> Phora = new Predicate<Phora>(findphora);


           Phora gh= phora.Find(emp => findphora(emp));

            Console.WriteLine("ID={0}, name={1},Age={2},DOB={3},Address={4}", gh.ID);
        }

        public static bool findphora(Phora emp)
        {
            return emp.DOB == 06/01/2000;
        }
    }
}