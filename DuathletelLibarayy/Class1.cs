using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DuathletelLibarayy
{
    public class Class1
    {
        public int Bib { get; set; }
        public string Name { get; set; }
        public int  agegroup { get; set; }
        public int Bike { get; set; }
        public int Run { get; set; }
        public int total{ get; set; }

        public override string ToString()
        {
            return Bib + " " + Name + " " + agegroup + "  " + Bike + " " + Run + " " + total;
        }
        public void ValidateBib()
        {
            if (Bib == 0)
                throw new ArgumentOutOfRangeException("Bib must be on number: " + Bib);
        }

        public void ValidateName()
        {
            if (Name == null)
                throw new ArgumentNullException("name is null");
            if (Name.Length < 1)
                throw new ArgumentException("NAME must be at least 4 character: " + Name);
        }

        public void Validategegroup()
        {
            if (agegroup <1 || agegroup > 4) throw new ArgumentOutOfRangeException(" age must be greater than 1: " + agegroup);
        }
        public void ValidateBike ()
        {
            if (Bib == null)
                throw new ArgumentOutOfRangeException("Bike must be on number: " + Bike);
        }
        public void ValidateRun()
        {
            if (Bib == null)
                throw new ArgumentOutOfRangeException("Bib must be on number: " + Run);
        }
        public void ValidatTotal()
        {
            if (total == 0)
                throw new ArgumentOutOfRangeException("Total  et tal beregnet som summen af Bike+Run:"  );
        }

        public void Validate()
        {
            ValidateBib();
            ValidateBike();
            ValidateName();
            Validategegroup();
            ValidateRun();
            ValidatTotal();
        }



    }
}