using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CustomListApp.ViewModals;
using System.Collections.ObjectModel;

namespace CustomListApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ListElementViewModal> elements { get; set; }

        public MainPage()
        {
            InitializeComponent();

            elements = new ObservableCollection<ListElementViewModal>();
            elements.Add(new ListElementViewModal
            {
                ID = 1,
                Name = "Apple",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/5/Red-Apple-PNG-Transparent.png",
                Info = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila). Apple trees are cultivated worldwide and are the most widely grown species in the genus Malus. The tree originated in Central Asia, where its wild ancestor, Malus sieversii, is still found today. Apples have been grown for thousands of years in Asia and Europe and were brought to North America by European colonists. Apples have religious and mythological significance in many cultures, including Norse, Greek and European Christian traditions."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 2,
                Name = "Banana",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/1/Banana-PNG.png",
                Info = "A banana is an edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa. In some countries, bananas used for cooking may be called plantains, distinguishing them from dessert bananas. The fruit is variable in size, color, and firmness, but is usually elongated and curved, with soft flesh rich in starch covered with a rind, which may be green, yellow, red, purple, or brown when ripe."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 3,
                Name = "Blackberry",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/7/Blackberry-Fruit-PNG-File.png",
                Info = "The blackberry is an edible fruit produced by many species in the genus Rubus in the family Rosaceae, hybrids among these species within the subgenus Rubus, and hybrids between the subgenera Rubus and Idaeobatus. The taxonomy of the blackberries has historically been confused because of hybridization and apomixis, so that species have often been grouped together and called species aggregates. For example, the entire subgenus Rubus has been called the Rubus fruticosus aggregate, although the species R. fruticosus is considered a synonym of R. plicatus."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 4,
                Name = "Broccoli",
                Category = "Vegetable",
                Image = "http://www.pngmart.com/files/8/Broccoli-PNG-Clipart-Background.png",
                Info = "Broccoli is an edible green plant in the cabbage family (Brassicas) whose large flowering head and stalk is eaten as a vegetable. The word broccoli comes from the Italian plural of broccolo, which means the flowering crest of a cabbage, and is the diminutive form of brocco, meaning small nail or sprout. Broccoli is classified in the Italica cultivar group of the species Brassica oleracea.Broccoli has large flower heads, usually green in color, arranged in a tree - like structure branching out from a thick, edible stalk.The mass of flower heads is surrounded by leaves.Broccoli resembles cauliflower, which is a different cultivar group of the same Brassica species.Combined in 2016, China and India produced 73 % of the world's broccoli and cauliflower crops."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 5,
                Name = "Corn",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/1/Sweet-Corn-PNG-File.png",
                Info = "Maize (/meɪz/ MAYZ; Zea mays subsp. mays, from Spanish: maíz after Taino: mahiz), also known as corn, is a cereal grain first domesticated by indigenous peoples in southern Mexico about 10,000 years ago. The leafy stalk of the plant produces pollen inflorescences and separate ovuliferous inflorescences called ears that yield kernels or seeds, which are fruits. The six major types of maize are dent corn, flint corn, pod corn, popcorn, flour corn, and sweet corn."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 6,
                Name = "Garlic",
                Category = "Vegetable",
                Image = "http://www.pngmart.com/files/6/Garlic-PNG-Clipart-1.png",
                Info = "Garlic (Allium sativum) is a species in the onion genus, Allium. Its close relatives include the onion, shallot, leek, chive and Chinese onion. Garlic is native to Central Asia and northeastern Iran and has long been a common seasoning worldwide, with a history of several thousand years of human consumption and use. It was known to ancient Egyptians, and has been used both as a food flavoring and as a traditional medicine. China produces some 80 % of the world supply of garlic."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 7,
                Name = "Lemon",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/1/Lemon-PNG-Clipart.png",
                Info = "The lemon, Citrus limon (L.) Osbeck, is a species of small evergreen tree in the flowering plant family Rutaceae, native to South Asia, primarily North eastern India. The tree's ellipsoidal yellow fruit is used for culinary and non-culinary purposes throughout the world, primarily for its juice, which has both culinary and cleaning uses. The pulp and rind (zest) are also used in cooking and baking. The juice of the lemon is about 5% to 6% citric acid, with a pH of around 2.2, giving it a sour taste. The distinctive sour taste of lemon juice makes it a key ingredient in drinks and foods such as lemonade and lemon meringue pie."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 8,
                Name = "Kiwi",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/1/Kiwi-Fruit-PNG-Transparent-Image.png",
                Info = "Kiwifruit (often abbreviated as kiwi), or Chinese gooseberry, is the edible berry of several species of woody vines in the genus Actinidia. The most common cultivar group of kiwifruit (Actinidia deliciosa 'Hayward') is oval, about the size of a large hen's egg (5–8 cm (2.0–3.1 in) in length and 4.5–5.5 cm (1.8–2.2 in) in diameter). It has a fibrous, dull and sour but edible greenish-brown skin and bright green or golden flesh with rows of tiny, black, edible seeds. The fruit has a soft texture with a sweet and unique flavour. China produced 56% of the world total of kiwifruit in 2016."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 9,
                Name = "Patato",
                Category = "Vegetable",
                Image = "http://www.pngmart.com/files/3/Potato-PNG-Clipart.png",
                Info = "The potato is a starchy, tuberous crop from the perennial nightshade Solanum tuberosum. In many contexts, potato refers to the edible tuber, but it can also refer to the plant itself. Common or slang terms include tater,[a] tattie and spud. Potatoes were introduced to Europe in the second half of the 16th century by the Spanish. Today they are a staple food in many parts of the world and an integral part of much of the world's food supply. As of 2014, potatoes were the world's fourth-largest food crop after maize (corn), wheat, and rice."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 10,
                Name = "Tomato",
                Category = "Vegetable",
                Image = "http://www.pngmart.com/files/1/Tomato-Clip-Art-PNG.png",
                Info = "The tomato is the edible, often red, berry of the plant Solanum lycopersicum, commonly known as a tomato plant. The species originated in western South America. The Nahuatl (Aztec language) word tomatl gave rise to the Spanish word tomate, from which the English word tomato derived. Its use as a cultivated food may have originated with the indigenous peoples of Mexico. The Spanish encountered the tomato from their contact with the Aztec during the Spanish colonization of the Americas and brought it to Europe. From there, the tomato was introduced to other parts of the European-colonized world during the 16th century."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 11,
                Name = "Onion",
                Category = "Vegetable",
                Image = "http://www.pngmart.com/files/1/Onion-Vector-Transparent-PNG.png",
                Info = "The onion (Allium cepa L., from Latin cepa onion), also known as the bulb onion or common onion, is a vegetable that is the most widely cultivated species of the genus Allium. Its close relatives include the garlic, leek, chive and Chinese onion. This genus also contains several other species variously referred to as onions and cultivated for food, such as the Japanese bunching onion(Allium fistulosum), the tree onion(A. ×proliferum), and the Canada onion(Allium canadense).The name wild onion is applied to a number of Allium species, but A.cepa is exclusively known from cultivation.Its ancestral wild original form is not known, although escapes from cultivation have become established in some regions."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 12,
                Name = "Strawberry",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/3/Strawberry-PNG-Image.png",
                Info = "The garden strawberry (or simply strawberry; Fragaria × ananassa) is a widely grown hybrid species of the genus Fragaria, collectively known as the strawberries. It is cultivated worldwide for its fruit. The fruit is widely appreciated for its characteristic aroma, bright red color, juicy texture, and sweetness. It is consumed in large quantities, either fresh or in such prepared foods as preserves, juice, pies, ice creams, milkshakes, and chocolates. Artificial strawberry flavorings and aromas are also widely used in many products like lip gloss, candy, hand sanitizers, perfume, and many others."
            });
            elements.Add(new ListElementViewModal
            {
                ID = 13,
                Name = "Watermelon",
                Category = "Fruit",
                Image = "http://www.pngmart.com/files/3/Watermelon-PNG-File.png",
                Info = "Citrullus lanatus is a plant species in the family Cucurbitaceae, a vine-like (scrambler and trailer) flowering plant originating in West Africa. It is cultivated for its fruit. The subdivision of this species into two varieties, watermelons (Citrullus lanatus (Thunb.) var. lanatus) and citron melons (Citrullus lanatus var. citroides (L. H. Bailey) Mansf.), originated with the erroneous synonymization of Citrullus lanatus (Thunb.) Matsum. & Nakai and Citrullus vulgaris Schrad. by L.H. Bailey in 1930."
            });
            FoodList.ItemsSource = elements;
        }

        async void ShowDetails(object sender, SelectedItemChangedEventArgs e)
        {
            var EnlargedPhotoPage = new DetailPage(e.SelectedItem as ListElementViewModal);
            await Navigation.PushModalAsync(EnlargedPhotoPage);
        }
    }
}
