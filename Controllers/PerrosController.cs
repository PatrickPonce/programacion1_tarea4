using Microsoft.AspNetCore.Mvc;
using TuProyecto.Models;

namespace TuProyecto.Controllers
{
    public class PerrosController : Controller
    {
        public IActionResult Index()
        {
            var lista = ObtenerPerros();
            return View(lista);
        }

        private List<Perro> ObtenerPerros()
        {
            return new List<Perro>
            {
                new Perro { Nombre = "Afador", Peso = "23–34 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/afador-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Affenhuahua", Peso = "2–4 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/affenhuahua-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Affenpinscher", Peso = "3–5 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/affenpinscher-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Aïdi (Atlas Mountain Dog)", Peso = "35–40 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/aidi-atlas-mountain-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Akbash", Peso = "34–41 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/akbash-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Akita Inu", Peso = "32–59 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/akita-inu-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Akita Chow", Peso = "40–66 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/akita-chow-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Akita Pitbull", Peso = "20–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/akita-pitbull-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Algodón de Tulear", Peso = "4–7 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/11/coton-de-tulear-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American Bully", Peso = "20–60 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/american-bully-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American Bulldog", Peso = "27–54 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2025/03/olde-english-bulldogge-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American Cocker Spaniel", Peso = "9–14 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/ariegeois-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American English Coonhound", Peso = "20–30 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/aso-ng-gubat-philippine-forest-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American Eskimo Dog", Peso = "8–16 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/askal-aspin-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American Foxhound", Peso = "27–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2025/04/treeing-tennessee-brindle-cur-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American Hairless Terrier", Peso = "5–7 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/azawakh-dog-breed-full-body-side-view-1024x768.webp" },
                new Perro { Nombre = "American Leopard Hound", Peso = "18–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/11/gascony-blue-bleu-de-gascogne-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "American Pit Bull Terrier", Peso = "13–30 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/american-pit-bull-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "American Staffordshire Terrier", Peso = "18–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/american-staffordshire-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "American Water Spaniel", Peso = "13–20 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/american-water-spaniel-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Anatolian Shepherd Dog", Peso = "36–68 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/anatolian-shepherd-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Appenzeller Sennenhund", Peso = "22–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/appenzeller-sennenhund-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Auggie", Peso = "9–14 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/auggie-aussie-corgi-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Aussiedoodle", Peso = "11–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/aussiedoodle-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Australian Cattle Dog", Peso = "16–23 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/aussiepom-dog-breed-full-body-side-view-1024x768.webp" },
                new Perro { Nombre = "Australian Kelpie", Peso = "14–21 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/australian-kelpie-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Australian Shepherd", Peso = "18–29 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/australian-shepherd-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Australian Terrier", Peso = "5–7 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/australian-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Azawakh", Peso = "15–25 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/azawakh-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Basset Fauve de Bretagne", Peso = "16–18 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/bosnian-barak-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Basset Hound", Peso = "20–29 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/barbado-da-terceira-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Bavarian Mountain Scent Hound", Peso = "20–25 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2025/04/barbet-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Beagle", Peso = "9–11 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/bardino-majorero-dog-breed-full-body-side-view-1024x768.webp" },
                new Perro { Nombre = "Bearded Collie", Peso = "18–27 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/basenji-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Bedlington Terrier", Peso = "7–10 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2025/07/greenland-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Belgian Laekenois", Peso = "25–30 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/bassador-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Belgian Malinois", Peso = "18–34 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/basset-artesien-normand-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Belgian Sheepdog", Peso = "18–34 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/blue-gascony-basset-dog-breed-full-body-1-1024x768.webp" },
                new Perro { Nombre = "Belgian Tervuren", Peso = "18–34 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/10/basset-fauve-de-bretagne-dog-breed-full-body-1024x768.webp" },
                new Perro { Nombre = "Bergamasco Sheepdog", Peso = "26–38 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bergamasco-sheepdog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Berger Picard", Peso = "23–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/berger-picard-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bernese Mountain Dog", Peso = "36–50 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bernese-mountain-dog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bichon Frise", Peso = "5–8 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bichon-frise-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Black and Tan Coonhound", Peso = "20–34 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/black-and-tan-coonhound-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Black Mouth Cur", Peso = "16–43 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/black-mouth-cur-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Black Russian Terrier", Peso = "36–68 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/black-russian-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bloodhound", Peso = "36–50 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bloodhound-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bluetick Coonhound", Peso = "20–36 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bluetick-coonhound-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Boerboel", Peso = "68–91 kg", Tamano = "Gigante", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/boerboel-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bolognese", Peso = "2.5–4 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bolognese-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Border Collie", Peso = "14–20 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/border-collie-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Border Terrier", Peso = "5–7 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/border-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Borzoi", Peso = "27–48 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/borzoi-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Boston Terrier", Peso = "4.5–11 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/boston-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bouvier Des Flandres", Peso = "32–50 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bouvier-des-flandres-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Boxador", Peso = "23–36 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/boxador-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Boxer", Peso = "25–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/boxer-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Boykin Spaniel", Peso = "11–18 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/boykin-spaniel-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bracco Italiano", Peso = "25–40 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bracco-italiano-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Braque Du Bourbonnais", Peso = "16–25 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/braque-du-bourbonnais-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Briard", Peso = "30–40 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/briard-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Brittany", Peso = "13–18 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/brittany-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Broholmer", Peso = "50–70 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/broholmer-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Brussels Griffon", Peso = "3–6 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/brussels-griffon-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bucovina Shepherd", Peso = "40–60 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bucovina-shepherd-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bull Terrier", Peso = "23–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bull-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bulldog", Peso = "18–25 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bulldog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Bullmastiff", Peso = "50–59 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/bullmastiff-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Cairn Terrier", Peso = "6–8 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/cairn-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Canaan Dog", Peso = "16–22 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/canaan-dog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Cane Corso", Peso = "40–50 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/cane-corso-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Cardigan Welsh Corgi", Peso = "11–17 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/cardigan-welsh-corgi-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Catahoula Leopard Dog", Peso = "20–36 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/catahoula-leopard-dog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Caucasian Shepherd Dog", Peso = "45–70 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/caucasian-shepherd-dog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Cavalier King Charles Spaniel", Peso = "5–8 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/cavalier-king-charles-spaniel-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Central Asian Shepherd Dog", Peso = "50–75 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/central-asian-shepherd-dog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Cesky Terrier", Peso = "8–10 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/cesky-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Chesapeake Bay Retriever", Peso = "25–36 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/chesapeake-bay-retriever-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Chihuahua", Peso = "1.5–3 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/chihuahua-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Chinese Crested", Peso = "3–6 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/chinese-crested-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Chinese Shar-Pei", Peso = "18–25 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/chinese-shar-pei-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Chinook", Peso = "23–39 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/chinook-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Chow Chow", Peso = "20–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/chow-chow-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Clumber Spaniel", Peso = "25–39 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/clumber-spaniel-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Cockapoo", Peso = "5–11 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/cockapoo-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Cocker Spaniel", Peso = "12–16 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/cocker-spaniel-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Collie", Peso = "20–29 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/collie-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Coonhound", Peso = "25–34 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/coonhound-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Coton de Tulear", Peso = "4–7 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/coton-de-tulear-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Curly-Coated Retriever", Peso = "29–36 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/curly-coated-retriever-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dachshund", Peso = "7–14 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dachshund-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dalmatian", Peso = "20–32 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dalmatian-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dandie Dinmont Terrier", Peso = "8–11 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dandie-dinmont-terrier-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Danish-Swedish Farmdog", Peso = "10–12 kg", Tamano = "Pequeño", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/danish-swedish-farmdog-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Deutsche Bracke", Peso = "18–25 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/deutsche-bracke-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dogo Argentino", Peso = "40–45 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dogo-argentino-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dogo Guatemalteco", Peso = "40–60 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dogo-guatemalteco-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dogo Mallorquin", Peso = "30–40 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dogo-mallorquin-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dogue de Bordeaux", Peso = "45–50 kg", Tamano = "Grande", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dogue-de-bordeaux-dog-breed-full-body-768x576.webp" },
                new Perro { Nombre = "Dutch Shepherd", Peso = "25–30 kg", Tamano = "Mediano", Imagen = "https://www.dogpackapp.com/blog/wp-content/uploads/2024/09/dutch-shepherd-dog-breed-full-body-768x576.webp" },

            };
        }


    }
}
