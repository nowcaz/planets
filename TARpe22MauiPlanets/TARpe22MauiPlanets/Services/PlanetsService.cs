using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe22MauiPlanets.Models;

namespace TARpe22MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "While Earth is only the fifth largest planet in the solar system, it is the only world in our solar system with liquid water on the surface. Just slightly larger than nearby Venus, Earth is the biggest of the four planets closest to the Sun, all of which are made of rock and metal.\r\n\r\nEarth is the only planet in the solar system whose English name does not come from Greek or Roman mythology. The name was taken from Old English and Germanic. It simply means \"the ground.\" There are, of course, many names for our planet in the thousands of languages spoken by the people of the third planet from the Sun.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "Our home planet",
                HeroImage = "earth.png",
                Description = "Earth, the third planet from the Sun, is a vibrant oasis in the vastness of space, teeming with life and characterized by its unique blend of ecosystems, landforms, and climatic zones. Its solid surface, sculpted over billions of years by geological processes such as tectonic activity, hosts a rich diversity of landscapes, from towering mountains to sprawling plains and deep ocean trenches. The planet's atmosphere, composed primarily of nitrogen and oxygen, sustains life by providing essential elements for respiration and climate regulation.\r\n\r\nAs the cradle of human civilization and countless other species, Earth plays host to a complex web of life, where flora and fauna thrive in a delicate balance. Its oceans, covering over 70% of the planet's surface, support a myriad of marine life, from microscopic plankton to majestic whales. Meanwhile, its terrestrial environments are home to a vast array of ecosystems, from lush rainforests to arid deserts, each hosting unique biodiversity and contributing to the planet's ecological richness.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "The second planet from the Sun",
                HeroImage = "venus.png",
                Description ="Venus, the second planet from the Sun, is often called Earth's twin due to its similar size and composition. However, it has a vastly different environment characterized by extreme heat, crushing atmospheric pressure, and acidic clouds.\r\n\r\nIts thick atmosphere primarily consists of carbon dioxide, with clouds of sulfuric acid obscuring its surface. These conditions create a hostile environment, with surface temperatures exceeding 870 degrees Fahrenheit (465 degrees Celsius), making Venus the hottest planet in our solar system.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Mars",
                Subtitle = "The fourth planet from the Sun",
                HeroImage = "mars.png",
                Description = "Mars, the fourth planet from the Sun, is a rocky world with a thin atmosphere, often referred to as the \"Red Planet\" due to its reddish appearance caused by iron oxide, or rust, on its surface.\r\n\r\nMars has long captivated human imagination as a potential destination for exploration and even colonization due to its similarities to Earth and the presence of water ice in polar caps and underground reservoirs. Numerous robotic missions, including NASA's Curiosity rover and Perseverance rover, have explored its surface, seeking signs of past or present life and furthering our understanding of Mars' geology and potential habitability.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The fifth planet from the Sun",
                HeroImage = "jupiter.png",
                Description = "Jupiter, the largest planet in our solar system, is a gas giant with a swirling atmosphere primarily composed of hydrogen and helium. It is known for its iconic banded appearance and the Great Red Spot, a massive storm system that has persisted for centuries.\r\n\r\nWith its extensive system of moons, including the four largest moons known as the Galilean moons, Jupiter offers a rich tapestry of exploration opportunities. These moons exhibit diverse features, from volcanic activity on Io to the potential for subsurface oceans on Europa, making them intriguing targets for scientific study.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "The sixth planet from the Sun",
                HeroImage = "saturn.png",
                Description = "Saturn, the sixth planet from the Sun, is renowned for its spectacular ring system, composed of icy particles and debris that orbit the planet in a vast disk. These rings, which stretch outwards from Saturn's equator, are one of the most distinctive features of the planet and make it a favorite subject for astronomers and space enthusiasts alike.\r\n\r\nBeyond its iconic rings, Saturn is also notable for its extensive family of moons, with over 80 known satellites orbiting the planet. Among these moons, Titan, the largest of Saturn's moons, is of particular interest due to its thick atmosphere and surface features, including lakes and rivers of liquid methane and ethane. Exploration of Saturn and its moons continues to provide valuable insights into the history and dynamics of the outer solar system.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "The seventh planet from the Sun",
                HeroImage = "uranus.png",
                Description = "Uranus, the seventh planet from the Sun, is an ice giant with a pale blue-green coloration due to the presence of methane in its atmosphere. It is unique among the planets in our solar system for its sideways rotation, with its axis of rotation tilted almost parallel to its orbital plane.\r\n\r\n    Despite its intriguing characteristics, Uranus remains relatively unexplored compared to other planets. Voyager 2 is the only spacecraft to have visited Uranus, providing valuable but limited data about its atmosphere, rings, and moons. Further exploration of Uranus could shed light on its mysterious features and contribute to our understanding of ice giants in the outer solar system.\r\n\r\n",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Neptune",
                Subtitle = "The eighth, and most distant planet from the Sun",
                HeroImage = "neptune.png",
                Description = "Neptune, the eighth and farthest planet from the Sun in our solar system, is a vibrant blue gas giant with striking cloud patterns and strong winds. It is primarily composed of hydrogen, helium, and methane, which gives it its distinctive color.\r\n\r\nKnown for its dynamic atmosphere and prominent storms, Neptune boasts the fastest winds in the solar system, with gusts reaching speeds of up to 1,500 miles per hour (2,400 kilometers per hour). Its most famous storm, the Great Dark Spot, discovered by the Voyager 2 spacecraft in 1989, has since dissipated, but new storms and atmospheric features continue to captivate astronomers.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            }
        };
    }
}

