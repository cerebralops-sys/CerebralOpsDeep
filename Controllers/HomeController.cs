using Microsoft.AspNetCore.Mvc;
using DeepExecutive.Models;

namespace DeepExecutive.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            Name = "Deepkumar Janardhanan",
            Designations = "VP Marketing | Head of Marketing | VP Technology | Global Technology Delivery",
            Positioning = "Technology Executive with Marketing Mastery",
            Introduction = "30+ years across technology, global delivery, B2B marketing, GTM and business transformation.",
            ProofPoints = new[] { "30+ Years", "800+ People Led", "$16M+ Portfolio", "13% YoY × 3 Years", "40→95% On-Time Delivery" },
            CaseStudies = new[]
            {
                new CaseStudyCard("Global Delivery Transformation", "Global Delivery", "Leadership, operating model and delivery transformation in a complex technology organization."),
                new CaseStudyCard("B2B Marketing & GTM", "Marketing & GTM", "Building and leading marketing capabilities across technology and B2B environments."),
                new CaseStudyCard("Technology & Product Leadership", "Technology", "Technology strategy, product engineering and transformation across complex initiatives."),
                new CaseStudyCard("SecureX", "Cybersecurity / Transformation", "A technology-led security initiative spanning 100+ projects, six business units and 1,000+ developers."),
                new CaseStudyCard("D2C Solution Architecture", "Ecommerce", "End-to-end technology architecture for a D2C online shop."),
                new CaseStudyCard("Client-Centered Solution Leadership", "Client Leadership", "Requirements, solution design and proactive alternatives focused on usability and business value.")
            }
        };

        return View(model);
    }

    public IActionResult Profile() => View();
    public IActionResult Experience() => View();
    public IActionResult CaseStudies() => View();
    public IActionResult Capabilities() => View();
    public IActionResult Resume() => View();
    public IActionResult Contact() => View();
    public IActionResult Error() => View();
}
