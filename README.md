# LabTask15
@Codebits Academy

using System;<br>
namespace Test {
    class Program {
        static void Main (string[] args) {
            // First data source - Articles
            List<Article> Articles = new List<Article> ();
            Articles.Add (new Article (1, 1, "Jovic returns to Real Madrid!", "Real Madrid striker Luka Jovic has returned from the coronavirus lockdown with a foot fracture, the club has revealed."));
            Articles.Add (new Article (2, 1, "LaLiga cool talks over June 20 resumption", "LaLiga insist that there remains no set date for the 2019-20 season to resume. On Thursday, Leganes coach Javier Aguirre claimed that the campaign - which was halted in March - would return on June 20 and be wrapped up five weeks later by July 26."));
            Articles.Add (new Article (3, 2, "Tinubu: 'My aide died of coronavirus'", "Former Lagos Governor and APC chieftain, Asiwaju Bola Ahmed Tinubu, has disclosed that his late Chief Security Officer, Alhaji Lateef Raheem, who died on Friday, April 25, 2020, passed on from COVID-19 complications."));
            Articles.Add (new Article (4, 2, "Appeal Court affirms Ifeanyi Ubah as senator-elect", "Justice Bello Kawu had on Jan. 17, nullified Ubah's election on grounds that he allegedly used a forged National Examination Council, (NECO) certificate to contest the senatorial election held in Anambra South on Feb. 23, 2019."));
            // Second data source - Categories
            List<Category> Categories = new List<Category> ();
            Categories.Add (new Category (1, "Sports"));
            Categories.Add (new Category (2, "Politics"));
            Categories.Add (new Category (3, "Religion"));
            Categories.Add (new Category (4, "Entertainment"));
            // Your task is as follows;
            // 1. Create a class call it Article with the following auto-implemented properties (Id, CategoryId, Title and Body) and a constructor for their initialization.
            // 2. Create another class call it Category with the following auto-implemented properties (Id, CategoryName) and a constructor for their initialization.
            // Looking at the two classes you will observe that there's a relationship between the two classes, in that, every article is linked to a category.
            // Now, using your knowledge of LINQ. Write a query that will join the two "data sources" and display the following data for each item in the returned Linq Query upon execution.
            // Article's Title
            // Article's Category
            // Article's Body
            // Hint: Consider looking at "Linq Join"
            // Submission: Saturday 9. Time 12:00pm
