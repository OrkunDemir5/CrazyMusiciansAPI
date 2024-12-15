using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CrazyMusiciansController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMusicians()
    {
        return Ok(new[]
        {
            new { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", Feature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", Feature = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new { Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", Feature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new { Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", Feature = "Nota üretirken sürekli sürprizler hazırlar" },
            new { Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", Feature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new { Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", Feature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
            new { Id = 7, Name = "Ali Perde", Profession = "Perde Uygulayıcı", Feature = "Her perdeyi farklı şekilde çalar; her zaman sürprizlidir" },
            new { Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", Feature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new { Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", Feature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
            new { Id = 10, Name = "Selin Akor", Profession = "Akor Sihirbazı", Feature = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
        });
    }
}
