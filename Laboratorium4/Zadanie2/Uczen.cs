namespace Zadanie2
{
    internal class Uczen : Osoba
    {
        public string Szkola { get; private set; }
        public bool MozeSamWracacDoDomu { get; private set; }
        public void SetSchool(string School) { Szkola = School; }
        public void ChangeSchool(string NewSchool) { Szkola = NewSchool; }
        public void SetCanGoHomeAlone(bool CanGoHomeAlone) { MozeSamWracacDoDomu = CanGoHomeAlone; }
        public override string GetEducationInfo()
        {
            return $"Uczeszcza do szkoly: {Szkola}.";
        }
        public override bool CanGoAloneToHome()
        {
            if (GetAge() < 12)
                return MozeSamWracacDoDomu;
            else
                return true;
        }
    }
}
