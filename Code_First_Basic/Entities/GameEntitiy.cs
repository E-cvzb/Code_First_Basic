using System.ComponentModel.DataAnnotations;

namespace Code_First_Basic.Entities
{
    public class GameEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        [Range(0,10 ,ErrorMessage ="0 ile 10 arasında bir sayı giriniz")]
        public decimal Rating { get; set; }
    }
}
