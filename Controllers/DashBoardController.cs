using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.Xml;
using WorldCups.Data;
using WorldCups.Models;
using WorldCups.Views.Home;

namespace WorldCups.Controllers
{
   
        public class DashBoardController : Controller
        {
        private readonly ApplicationDibContext _context;
        private IWebHostEnvironment _webHostEnvironment;
        public DashBoardController(ApplicationDibContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }
            public IActionResult Index()
            {
                return View();
            }

       
        public IActionResult CreateNewCategories(Categries categries)
        {
            _context.Add(categries);
            _context.SaveChanges();

            return RedirectToAction("Categories");
        }
        public IActionResult CreateNewCatogorisTransportation(CatogorisTransportation catogorisTransportation)
        {
            _context.Add(catogorisTransportation);
            _context.SaveChanges();
            return RedirectToAction("CatogorisTransportation");

        }
        public IActionResult Categries()
        {
            var getdata = _context.Categries.ToList();
            return View(getdata);
        }
        public IActionResult CatogorisTransportation()
        {
            var getdata = _context.CatogorisTransportation.ToList();

            return View(getdata);
        }

        public IActionResult CreateNewHotel(Hotel hotel,IFormFile photo)
        {
            if(photo == null  || photo.Length == 0){
                return Content("File Not Select");
            }
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "iamges", photo.FileName);
            using(FileStream straem= new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(straem);
                straem.Close();

            }
            hotel.Images = photo.FileName;
            _context.Add(hotel);
            _context.SaveChanges();
            return RedirectToAction("Hotel");

        }
        public IActionResult Hotel()
        {
            var getdata = _context.Hotel.ToList();

            return View(getdata);

        }

      

        public IActionResult CreateNewTransport(Transport transport, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                return Content("File Not Select");
            }
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "iamges", photo.FileName);
            using (FileStream straem = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(straem);
                straem.Close();

            }
            transport.Images = photo.FileName;
            _context.Add(transport);
            _context.SaveChanges();
            return RedirectToAction("Transport");

        }
        public IActionResult Transport()
        {
            var getdata = _context.Transport.ToList();
            ViewBag.getdata = getdata;
            return View();
        }


        
        public IActionResult CreateNewstudium1(studium1 studium, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                return Content("File Not Select");
            }
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "iamges", photo.FileName);//path
            using (FileStream straem = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(straem);
                straem.Close();

            }


            studium.Iamges = photo.FileName;
            _context.Add(studium);
            _context.SaveChanges();

            return RedirectToAction("studium1");



            return View("studium1");
        }




        public IActionResult studium1()
        {
            var getdata = _context.studium1.ToList();

            return View(getdata);

        } 
        public IActionResult TableFootbul()
        {
            var getdata = _context.studium1.ToList();
            ViewBag.getdata = getdata;
            var tableFootbul = _context.TableFootbul.ToList();

            var getdatatableFootbul = _context.TableFootbul.Join(

                _context.studium1, 
                
                TableFootbul => TableFootbul.studium1_id, 

                studium1 => studium1.Id, 

                (TableFootbul, studium1) => new 
                { Id = TableFootbul.Id,
                    NameA = TableFootbul.Name,
                    NameB = studium1.Name, 
                    City = TableFootbul.Ctiy, 
                    Ateam1 = TableFootbul.Ateam1,
                    Ateam2 = TableFootbul.Ateam2, 
                    MatchTimeA = TableFootbul.MatchTime 
                }).ToList();
            ViewBag.getdataTableFootbul = getdatatableFootbul;

            return View(tableFootbul);
        }

        public IActionResult CreateNewTableFootbul(TableFootbul tableFootbul)
        {
            


            if (ModelState.IsValid)
            {
                _context.Add(tableFootbul);
                _context.SaveChanges();
                TempData["Save"] = "تمت عملية الحفظ";
                return RedirectToAction("studium1");
            }
            TempData["Save"] = "لم عملية الحفظ";
            return View("TableFootbul");


        }

        public IActionResult Deletestudium1(int id)
        {
            var studium1 = _context.studium1.SingleOrDefault(c => c.Id == id);
            if (studium1 != null)
            {
                _context.studium1.Remove(studium1);
                _context.SaveChanges();
            }
            return RedirectToAction("studium1");
        }
       
        public IActionResult Editestudium1(int id)
        {
            var edit_studium1 = _context.studium1.SingleOrDefault(e=>e.Id==id);
            return View(edit_studium1);
           

    }
       
       public IActionResult Updatestudium1(studium1 studium1, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                return Content("File Not Select");
            }
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "iamges", photo.FileName);
            using (FileStream straem = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(straem);
                straem.Close();

            }
            

            studium1.Iamges = photo.FileName;
            _context.studium1.Update(studium1);
            _context.SaveChanges();
            return RedirectToAction("studium1");

        }

    }
}









