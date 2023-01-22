using NUnit.Framework;
using System;
using System.Numerics;

namespace FootballTeam.Tests
{
    public class Tests
    {
        FootballPlayer Messi;
        private string PlayerName = "Messi";
        private int PlayerNumber = 13;
        private string PlayerPosition = "Midfielder";
        FootballTeam BGNatoional;
        private string TeamName = "BGNatoional";
        private int TeamCap = 16;

        [SetUp]
        public void Setup()
        {
            Messi = new FootballPlayer(PlayerName, PlayerNumber, PlayerPosition);
            BGNatoional = new FootballTeam(TeamName, TeamCap);

        }

        [Test]
        public void FootballPlayer_ConstructorShouldNotThrow()
        {
            Assert.DoesNotThrow(() =>
            {
                FootballPlayer Messi = new FootballPlayer(PlayerName, PlayerNumber, PlayerPosition);
            }
            );
        }
        [Test]
        public void FootballPlayer_NameShouldThrowIfNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballPlayer Messi = new FootballPlayer("", PlayerNumber, PlayerPosition);
            }
            );
            Assert.Throws<ArgumentException>(() =>
            {
                FootballPlayer Messi = new FootballPlayer(null, PlayerNumber, PlayerPosition);
            }
            );
        }
        [Test]
        public void FootballPlayer_PlayerNumberShouldThrowIfValueIsIncorect()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballPlayer Messsi = new FootballPlayer(PlayerName, 0, PlayerPosition);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                FootballPlayer Messsi = new FootballPlayer(PlayerName, 22, PlayerPosition);
            });
        }
        [Test]
        public void FootballPlayer_PositionShouldThrowIfValueIsIncorect()
        {
            Assert.DoesNotThrow(() =>
            {
                FootballPlayer Messsi = new FootballPlayer(PlayerName, PlayerNumber, "Goalkeeper");
            });
            Assert.DoesNotThrow(() =>
            {
                FootballPlayer Messsi = new FootballPlayer(PlayerName, PlayerNumber, "Midfielder");
            });
            Assert.DoesNotThrow(() =>
            {
                FootballPlayer Messsi = new FootballPlayer(PlayerName, PlayerNumber, "Forward");
            });
            Assert.Throws<ArgumentException>(() =>
            {
                FootballPlayer Messsi = new FootballPlayer(PlayerName, PlayerNumber, "Sistan");
            });
        }
        [Test]
        public void FootballPlayer_ScoredGoalsShouldWork()
        {
            Assert.AreEqual(Messi.ScoredGoals, 0);
        }
        [Test]
        public void FootballPlayer_ScoreShouldWork()
        {
            Messi.Score();
            Assert.AreEqual(Messi.ScoredGoals, 1);
        }
        [Test]
        public void FootballTeam_ConstructorShouldNotThrow()
        {
            Assert.DoesNotThrow(() =>
            {
                FootballTeam BGNatoional = new FootballTeam(TeamName, TeamCap);
            });
            Assert.AreEqual(BGNatoional.Players.Count, 0);
        }
        [Test]
        public void FootballTeam_NameShouldThrow()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballTeam BGNatoional = new FootballTeam(null, TeamCap);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                FootballTeam BGNatoional = new FootballTeam("", TeamCap);
            });
        }
        [Test]
        public void FootballTeam_CapacityShouldThrow()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballTeam BGNatoional = new FootballTeam(TeamName, 14);
            });
        }
        [Test]
        public void FootballTeam_AddNewPlayerShoudThrowIfMoreThatCap()
        {
            BGNatoional.AddNewPlayer(new FootballPlayer("Sessi", 1, "Goalkeeper"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Kessi", 1, "Midfielder"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Aessi", 1, "Midfielder"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Lessi", 1, "Midfielder"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Eessi", 1, "Midfielder"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Bessi", 1, "Midfielder"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Gessi", 1, "Forward"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Fessi", 1, "Forward"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Qessi", 1, "Forward"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Wessi", 1, "Forward"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Yessi", 1, "Forward"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Tessi", 1, "Forward"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Iessi", 1, "Midfielder"));
            BGNatoional.AddNewPlayer(new FootballPlayer("Oessi", 1, "Goalkeeper"));
            BGNatoional.AddNewPlayer(new FootballPlayer("KEGessi", 1, "Goalkeeper"));
            BGNatoional.AddNewPlayer(new FootballPlayer("eEGessi", 1, "Goalkeeper"));
            Assert.AreEqual("No more positions available!", BGNatoional.AddNewPlayer(new FootballPlayer("Pessi", 1, "Goalkeeper")));
        }
        [Test]
        public void FootballTeam_AddPlayerShouldReturnCorrectly()
        {
            Assert.AreEqual("Added player Pessi in position Goalkeeper with number 1", BGNatoional.AddNewPlayer(new FootballPlayer("Pessi", 1, "Goalkeeper")));
        }
        [Test]
        public void FootballTeam_AddPlayerShouldActuallyAdd()
        {
            BGNatoional.AddNewPlayer(new FootballPlayer("Pessi", 1, "Goalkeeper"));
            Assert.AreEqual(BGNatoional.Players.Count, 1);
        }
        [Test]
        public void FootballTeam_PickPlayerShouldWork()
        {
            BGNatoional.AddNewPlayer(new FootballPlayer("Pessi", 1, "Goalkeeper"));
            FootballPlayer pessi = BGNatoional.PickPlayer("Pessi");
            Assert.AreEqual(pessi.Name,"Pessi");
        }
        [Test]
        public void FootballTeam_PlayerScore()
        {
            BGNatoional.AddNewPlayer(new FootballPlayer("Pessi", 1, "Goalkeeper"));
            FootballPlayer pessi = BGNatoional.PickPlayer("Pessi");
            Assert.AreEqual($"{pessi.Name} scored and now has {pessi.ScoredGoals + 1} for this season!", BGNatoional.PlayerScore(1));
        }
    }
}