# LabTask15
@Codebits Academy

using System;<br>
namespace Test<br. {
    class Program <br> {
        static void Main (string[] args) {<br>
            // First data source - Articles<br>
            List<Article> Articles = new List<Article> ();<br>
            Articles.Add (new Article (1, 1, "Jovic returns to Real Madrid!", "Real Madrid striker Luka Jovic has returned from the coronavirus lockdown with a foot fracture, the club has revealed."));<br>
            Articles.Add (new Article (2, 1, "LaLiga cool talks over June 20 resumption", "LaLiga insist that there remains no set date for the 2019-20 season to resume. On Thursday, Leganes coach Javier Aguirre claimed that the campaign - which was halted in March - would return on June 20 and be wrapped up five weeks later by July 26."));<br>
            Articles.Add (new Article (3, 2, "Tinubu: 'My aide died of coronavirus'", "Former Lagos Governor and APC chieftain, Asiwaju Bola Ahmed Tinubu, has disclosed that his late Chief Security Officer, Alhaji Lateef Raheem, who died on Friday, April 25, 2020, passed on from COVID-19 complications."));<br>
            Articles.Add (new Article (4, 2, "Appeal Court affirms Ifeanyi Ubah as senator-elect", "Justice Bello Kawu had on Jan. 17, nullified Ubah's election on grounds that he allegedly used a forged National Examination Council, (NECO) certificate to contest the senatorial election held in Anambra South on Feb. 23, 2019."));<br>
            // Second data source - Categories<br>
            List<Category> Categories = new List<Category> ();<br>
            Categories.Add (new Category (1, "Sports"));<br>
            Categories.Add (new Category (2, "Politics"));<br>
            Categories.Add (new Category (3, "Religion"));<br>
            Categories.Add (new Category (4, "Entertainment"));<br>
            // Your task is as follows;<br>
            // 1. Create a class call it Article with the following auto-implemented properties (Id, CategoryId, Title and Body) and a constructor for their initialization.<br>
            // 2. Create another class call it Category with the following auto-implemented properties (Id, CategoryName) and a constructor for their initialization.<br>
            // Looking at the two classes you will observe that there's a relationship between the two classes, in that, every article is linked to a category.<br>
            // Now, using your knowledge of LINQ. Write a query that will join the two "data sources" and display the following data for each item in the returned Linq Query upon execution.<br>
            // Article's Title<br>
            // Article's Category<br>
            // Article's Body<br>
            // Hint: Consider looking at "Linq Join"<br>
            // Submission: Saturday 9. Time 12:00pm<br>
