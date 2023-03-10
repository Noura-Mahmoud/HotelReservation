using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Entites
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required]
        [Column("birth_day")]
        public string BirthDay { get; set; }

        [Required]
        [Column("gender")]
        public string Gender { get; set; }

        [Required]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Column("email_address")]
        public string EmailAddress { get; set; }

        [Required]
        [Column("number_guest")]
        public int NumberGuest { get; set; }

        [Required]
        [Column("street_address")]
        public string StreetAddress { get; set; }

        [Required]
        [Column("apt_suite")]
        public string AptSuite { get; set; }

        [Required]
        [Column("city")]
        public string City { get; set; }

        [Required]
        [Column("state")]
        public string State { get; set; }

        [Required]
        [Column("zip_code")]
        public string ZipCode { get; set; }

        [Required]
        [Column("room_type")]
        public string RoomType { get; set; }

        [Required]
        [Column("room_floor")]
        public string RoomFloor { get; set; }

        [Required]
        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Required]
        [Column("total_bill")]
        public float TotalBill { get; set; }

        [Required]
        [Column("payment_type")]
        public string PaymentType { get; set; }

        [Required]
        [Column("card_type")]
        public string CardType { get; set; }

        [Required]
        [Column("card_number")]
        public string CardNumber { get; set; }

        [Required]
        [Column("card_exp")]
        public string CardExp { get; set; }

        [Required]
        [Column("card_cvc")]
        public string CardCvc { get; set; }

        [Required]
        [Column("arrival_time")]
        public DateTime ArrivalTime { get; set; }

        [Required]
        [Column("leaving_time")]
        public DateTime LeavingTime { get; set; }

        [Required]
        [Column("check_in")]
        public bool CheckIn { get; set; }

        [Required]
        [Column("break_fast")]
        public int BreakFast { get; set; }

        [Required]
        [Column("lunch")]
        public int Lunch { get; set; }

        [Required]
        [Column("dinner")]
        public int Dinner { get; set; }

        [Required]
        [Column("cleaning")]
        public bool Cleaning { get; set; }

        [Required]
        [Column("towel")]
        public bool Towel { get; set; }

        [Required]
        [Column("s_surprise")]
        public bool SSurprise { get; set; }

        [Required]
        [Column("supply_status")]
        public bool SupplyStatus { get; set; }

        [Required]
        [Column("food_bill")]
        public int FoodBill { get; set; }

        public override string ToString()
        {
            return RoomNumber+ "  "+ RoomType+ "  " + Id+"       "+ FirstName+" "+ LastName+ "  "+ PhoneNumber;
        }

    }
}
