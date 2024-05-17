using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tareaasp.Pages
{
    public class programa2Model : PageModel
    {
        [BindProperty]
        public string Message { get; set; } = "";
        [BindProperty]
        public int Shift { get; set; }
        public string EncodedMessage = "";
        public string DecodedMessage = "";
        public void OnPost()
        {
            EncodedMessage = Encode(Message, Shift);
            DecodedMessage = Decode(EncodedMessage, Shift);
        }

        private string Encode(string message, int shift)
        {
            return new string(message.Select(c => char.IsLetter(c) ? (char)(((c & 223) - 65 + shift) % 26 + (c & 32) + 65) : c).ToArray());
        }

        private string Decode(string message, int shift)
        {
            return Encode(message, 26 - shift);
        }
    }
}
