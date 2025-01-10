namespace ARobinsonMC5Eight2Ten_EndPnt.Services
{
    public class Magic8Services
    {
        public string goMagic8(string question)
        {
            string[] QuestionReplies = {"Yes, of course.", "Yes, but I wouldn't be so sure.", "I am unsure, perhaps theres a reason why.", "I am not equipped to answer this one, you are on your own.", "I don't think so, this may be something that requires more thought.", "Maybe yes, maybe no, there's no telling.", "No, be wary of this choice.", "Absolutely not."};
            Random rng = new Random();
            int randomReply = rng.Next(QuestionReplies.Length + 1);
            return QuestionReplies[randomReply];
        }
    }
}