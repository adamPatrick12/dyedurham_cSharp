using NUnit.Framework;
using System.Collections.Generic;
using UnsortedNames;

namespace Tests
{
    [TestFixture]
    public class NameSorterTests
    {
        [Test]
        public void SortByLastName_ShouldSortNamesAlphabeticallyByLastName()
        {
            // Setup unsorted list
            List<string> names = new List<string>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritt"
            };

            // Setup sorted list

            List<string> expectedSortedNames = new List<string>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritt",
                "Shelby Nathan Yoder"
            };

            // Act
            List<string> sortedNames = NameSorter.SortByLastName(names);

            // Assert
            Assert.That(sortedNames, Is.EqualTo(expectedSortedNames));
        }

 
    }
}