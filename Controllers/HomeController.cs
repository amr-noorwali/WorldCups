using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using Microsoft.AspNetCore.Mvc;
using WorldCups.Data;
using WorldCups.Models;
using WorldCups.Views.Home;
using static System.Net.Mime.MediaTypeNames;

namespace WorldCups.Controllers
{
    public class HomeController : Controller
    {

       
        private readonly ApplicationDibContext _context;//global


       public HomeController(ApplicationDibContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Categries = _context.Categries.ToList();

            /*  var Categries = new List<Categries>
              {
                  new Categries
              {
                  Id =1,
                  Name =" الملاعب",
                  Icon =" <i class=\"fa fa-futbol-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",

                  Url ="studium1",


              },
                  new Categries
              {
                  Id =2,
                  Name =" جدول المباريات",
                  Icon =" <i class=\"fa fa-clock-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
                  Url="TableFootbul",


              },new Categries
              {
                  Id =3,
                  Name =" الفنادق",
                  Icon =" <i class=\"fa fa-bed text-success\"aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
                  Url="Hotel",


              },

              };*/
            return View(Categries);
            
        }

        public IActionResult studium1()
        {
            var studium1 = new List<studium1>
            {
                new studium1
                {
                    Id=1,
                    Name= "ملعب مدينة الملك فهد الرياضية",
                    Capcity=67892,
                    city="الرياض",
                    Type="كرة القدم",
                    ConstractionDate = new DateTime(2024, 12, 30),
                    Owner="الهيئة العامة للرياضة",
                    Length=123,
                    Width=89,
                  Facility=new List<string>{ "مواقف سيارات"," شاشات عملاقة"," مطاعم"},
                     Iamges="iamges/mm1.jpg",





                },
                 new studium1
                {
                    Id=2,
                    Name= "ملعب مدينة الملك عبد الله الرياضية",
                    Capcity=6789,
                    city="جدة",
                    Type="كرة القدم",
                    ConstractionDate= new DateTime(2024, 12, 30),
                    Owner="الهيئة العامة للرياضة",
                    Length=123,
                    Width=89,
                    Facility=new List<string>{ "مواقف سيارات"," شاشات عملاقة"," مطاعم"},
                    Iamges="iamges/princefaisal.jpg",






                }, new studium1
                {
                    Id=3,
                    Name= "ملعب مدينة الملك عبد العزيز الرياضية",
                    Capcity=6789,
                    city="مكة المكرمة",
                    Type="كرة القدم",
                    ConstractionDate=new DateTime(2024, 12, 30),
                    Owner="الهيئة العامة للرياضة",
                    Length=123,
                    Width=89,
                    Facility=new List<string>{ "مواقف سيارات"," شاشات عملاقة"," مطاعم"},
                    Iamges="iamges/m2.jpg",






                }, new studium1
                {
                    Id=4,
                    Name= "ملعب مدينة الأمير عبد الله الفيصل الرياضية",
                    Capcity=6789,
                    city="جدة",
                    Type="كرة القدم",
                    ConstractionDate=new DateTime(2024, 12, 30),
                    Owner="الهيئة العامة للرياضة",
                    Length=123,
                    Width=89,
                  Facility=new List<string>{ "مواقف سيارات"," شاشات عملاقة"," مطاعم"},
                    Iamges="iamges/m1.jpg",






                },
            };
            return View(studium1);
        }

        //start Hotel

        public IActionResult Hotel()
        {
            var Hotel = new List<Hotel>
            {
                new Hotel
                {
                    Id=1,
                    Name ="Qasr Al Ansar Golden Tulip Hotel",
                    Description="Three Bedroom Suite with Two Bathrooms Private suite • 3 bedrooms • 2 bathrooms • 60m²",
                    Images="iamges/13.jpeg",
                    City="Dammam",
                    Price=2000,
                   

                },
                 new Hotel
                {
                    Id=2,
                    Name ="Bab Samhan, a Luxury Collection Hotel",
                    Description="Three Bedroom Suite with Two Bathrooms Private suite • 3 bedrooms • 2 bathrooms • 60m²",
                    Images="iamges/14.jpeg",
                    City="Dammam",
                    Price=2000,

                },
                  new Hotel
                {
                    Id=3,
                    Name ="Bab Samhan, a Luxury Collection Hotel",
                    Description="Three Bedroom Suite with Two Bathrooms Private suite • 3 bedrooms • 2 bathrooms • 60m²",
                    Images="iamges/15.jpg",
                    City="Dammam",
                    Price=2000,

                },
                   new Hotel
                {
                    Id=4,
                    Name ="Bab Samhan, a Luxury Collection Hotel",
                    Description="Three Bedroom Suite with Two Bathrooms Private suite • 3 bedrooms • 2 bathrooms • 60m²",
                    Images="iamges/184305239.jpg",
                    City="Dammam",
                    Price=2000,

                },
                    new Hotel
                {
                    Id=5,
                    Name ="Bab Samhan, a Luxury Collection Hotel",
                    Description="Three Bedroom Suite with Two Bathrooms Private suite • 3 bedrooms • 2 bathrooms • 60m²",
                    Images="iamges/15.jpg",
                    City="Dammam",
                    Price=2000,

                },

            };
            return View(Hotel);
        }


        //end Hotel
        //start TableFootbul

        public IActionResult TableFootbul()
        {
            var TableFootbul = new List<TableFootbul>
            {
                new TableFootbul
                {
                    Id=1,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="الارجنتين",
                    Ateam2="البرتغال",
                   MatchTime= new DateTime(2034, 12, 30, 8, 30, 0 ),
                    Ctiy ="الرياض",
                },
                new TableFootbul
                {
                    Id=2,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="الاكوادور",
                    Ateam2="قطر",
                   MatchTime= new DateTime(2034, 12, 30, 8, 30, 0 ),
                    Ctiy ="الرياض",
                },
                new TableFootbul
                {
                    Id=3,
                    Name="ملعب مدينة الملك عبدالله",
                    Ateam1="" +
                    "السعودية",
                    Ateam2="البرتغال",
                   MatchTime= new DateTime(2034, 12, 30, 9, 30, 0 ),
                    Ctiy ="جدة",
                },
                new TableFootbul
                {
                    Id=4,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="غانا",
                    Ateam2="صربيا",
                    MatchTime= new DateTime(2034, 12, 30, 8, 30, 0 ),
                    Ctiy ="الرياض",
                },
                new TableFootbul
                {
                    Id=5,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="كوريا الجنوبية",
                    Ateam2="برازيل",
                   MatchTime= new DateTime(2034, 12, 30, 10, 30, 0 ),
                    Ctiy ="الرياض",
                },
                new TableFootbul
                {
                    Id=6,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="الارجنتين",
                    Ateam2="البرتغال",
                    MatchTime= new DateTime(2034, 12, 30, 10, 30, 0 ),
                    Ctiy ="الرياض",
                },
                new TableFootbul
                {
                    Id=7,
                    Name="ملعب جامعة الملك سعود",
                    Ateam1="الاكوادور",
                    Ateam2="كندا",
                   MatchTime= new DateTime(2034, 12, 30, 8, 30, 0 ),
                    Ctiy ="الرياض",
                },
                new TableFootbul
                {
                    Id=8,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="المكسيك",
                    Ateam2="المكسيك",
                    MatchTime= new DateTime(2034, 12, 30, 8, 0, 0 ),
                    Ctiy ="الرياض",
                },new TableFootbul
                {
                    Id=9,
                    Name="ملعب مدينة الملك سعود",
                    Ateam1="السنغال",
                    Ateam2="البرتغال",
                    MatchTime= new DateTime(2034, 12, 30, 9, 30, 0 ),
                    Ctiy ="الدمام",
                },new TableFootbul
                {
                    Id=10,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="فرنسا",
                    Ateam2="برازيل",
                    MatchTime= new DateTime(2034, 12, 30, 8, 0, 0 ),
                    Ctiy ="الرياض",
                },new TableFootbul
                {
                    Id=11,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="كرواتيا",
                    Ateam2="المغرب",
                    MatchTime= new DateTime(2034, 12, 30, 8, 30, 0 ),
                    Ctiy ="الرياض",
                },new TableFootbul
                {
                    Id=12,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="الارجنتين",
                    Ateam2="البرتغال",
                   MatchTime= new DateTime(2034, 12, 30, 9, 30, 0 ),
                    Ctiy ="الرياض",
                },new TableFootbul
                {
                    Id=13,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="هولندا",
                    Ateam2="البرتغال",
                    MatchTime= new DateTime(2034, 12, 30, 9, 30, 0 ),
                    Ctiy ="الدمام",
                },new TableFootbul
                {
                    Id=14,
                    Name="ملعب مدينة الملك فهد",
                    Ateam1="اليابان",
                    Ateam2="المغرب",
                    MatchTime= new DateTime(2034, 12, 30, 8, 30, 0 ),
                    Ctiy ="الرياض",
                },
            };
            return View(TableFootbul);
        }


        //end TableFootbul



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
