namespace ObligatoriskOpgave
{
    public class Trophy
    {
        //Egenskaber (Properties) 
        public int Id { get; set; }
        public string Competition { get; set; }
        public int Year { get; set; }
        



        //Metode kalder til konverte objektet til tekst(string) så det kan vises på en læsbar måde
        public override string ToString()
        {
            //Returne en tekst (string), som indholder af Id, competition og year
            return $"Id: {Id}, Competition: {Competition}, Year: {Year}";
        }

        //Denne metode tjekker, om competition-egenskaben er gyldig
        public void ValidateCompetition()
        {
            //tjekker om Competition er null(ikke sat)
            if (Competition == null)
            {
                //Hvis competition er null, smides der en fejl besked 
                throw new ArgumentNullException("Competition cannot be null");
            }
            //tjekker om længen på teksten er større end 3 i Competition
            if(Competition.Length < 3) 
            {
                //Hvis den er over 3, smides der en fejl besked 
            throw new ArgumentOutOfRangeException("Competition skal maks være 3 bogstaver");
            }
        }


        // Denne metode tjekker, om Year-egenskaben er gyldig

        public void ValidateYear()
        {
            // Tjekker om Year er mindre end 1970 eller større end 2024
            if (Year < 1970 || Year > 2024)
          
            {
                // Hvis Year ikke er mellem 1970 og 2024, smides en fejl med en besked
                throw new ArgumentOutOfRangeException("Mindst årgang 1969 og maks 2024");
            }
        }
        //Denne metode tjekker alle egenskaber på en gang
        public void Validate()
        {
            //Kalder metoden til at tjekke competition-egenskaben
            ValidateCompetition();
            //Kalder metioden til at tjekke Year-egenskaben
            ValidateYear();
        }
    }
}


    
