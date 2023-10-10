using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace TimeDisplay.Controllers;
public class TimeController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public ViewResult Index()
    {
        DateTime CurrentTime = DateTime.Now;
        DateTime EndTime = DateTime.Now.AddHours(9).AddDays(15).AddMonths(2);

        TimeSpan TimeDifference = EndTime - CurrentTime;

        ViewBag.CurrentTime = CurrentTime.ToString("MMM dd, yyyy, hh:mm tt");
        ViewBag.EndTime = EndTime.ToString("MMM dd, yyyy, hh:mm tt");
        ViewBag.RemainingTime = $"{TimeDifference.Days} days, {TimeDifference.Hours} hours, {TimeDifference.Minutes} minutes remaining";
        return View();
    }
}