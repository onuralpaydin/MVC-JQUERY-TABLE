using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;
using TEST.CustomValidations;

namespace TEST.VievModels
{
    public class PersonPetVM
    {
        [Display(Name = "Person Name")]
        [Required]
        public string PersonName { get; set; }

        [Display(Name = "Person Surname")]
        [Required]
        public string PersonSurname { get; set; }

        [Display(Name = "Person BirthDay")]
        [Required]
        [BirthDateValidation]
        public DateTime PersonBirthDate { get; set; }

        [Display(Name = "Person Gender")]
        [Required]
        public Gender PersonGender { get; set; }

        [Display(Name = "Pet Name")]
        [Required]
        public string PetName { get; set; }

        [Display(Name = "Pet Type")]
        [Required]
        public string PetType { get; set; }

        [Display(Name = "Pet Number of Feet")]
        [FeetValidation]
        public int PetNumberOfFeet { get; set; }

        [Display(Name = "Pet Age")]
        [Range(0, 15)]
        [Required]
        public int PetAge { get; set; }

        [Display(Name = "Pet Gender")]
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public Gender PetGender { get; set; }

        [Display(Name = "Pet Weight")]
        [Required]
        public decimal PetWeight { get; set; }

        [Display(Name = "Nutrition Type")]
        [Required]
        public TypeOfNutrition PetNutritionType { get; set; }
    }

}
public enum Gender { Woman, Man };
public enum TypeOfNutrition { Carnivorous, Herbivorous, Omnivore };