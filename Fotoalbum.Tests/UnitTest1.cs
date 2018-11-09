using System;
using System.Linq;
using Fotoalbum.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fotoalbum.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Create_MainViewModel()
        {
            // Arrange -> Initialisieren
            // Act     -> Aufrufen 
            // Assert  -> Ergebnis interpretieren

            MainViewModel mv = new MainViewModel();
            Assert.IsNotNull(mv);
        }

        [TestMethod]
        public void MainViewModel_Can_Get_Alben()
        {
            MainViewModel mv = new MainViewModel();
            mv.GetAlbenCommand.Execute(null);

            Assert.IsNotNull(mv.Alben);
            Assert.IsTrue(mv.Alben.Count > 0); // wir wissen dass die DB immer 100 Alben zurückliefert
        }

        [TestMethod]
        public void MainViewModel_Check_If_GetFotosFromAlbumCommand_Return_Foto_From_Wrong_Album()
        {
            MainViewModel mv = new MainViewModel();
            mv.GetAlbenCommand.Execute(null);
            mv.CurrentSelectedAlbum = mv.Alben[0]; // Simulation "Klick auf Album"

            mv.GetFotosFromAlbumCommand.Execute(null);

            Assert.IsNotNull(mv.FotosAusAktuellemAlbum);
            Assert.IsTrue(mv.FotosAusAktuellemAlbum.Count > 0); // wir wissen dass die DB immer 100 Alben zurückliefert
            Assert.IsFalse(mv.FotosAusAktuellemAlbum.Any(x => x.AlbumId != mv.CurrentSelectedAlbum.Id)); // Es darf kein Foto aus einem falschen Album vorhanden sein ...
        }

        [TestMethod]
        public void MainViewModel_Check_All_Alben_If_GetFotosFromAlbumCommand_Return_Foto_From_Wrong_Album()
        {
            MainViewModel mv = new MainViewModel();
            mv.GetAlbenCommand.Execute(null);
            foreach (var item in mv.Alben)
            {
                mv.CurrentSelectedAlbum = item; // Simulation "Klick auf Album"

                mv.GetFotosFromAlbumCommand.Execute(null);

                Assert.IsNotNull(mv.FotosAusAktuellemAlbum);
                Assert.IsTrue(mv.FotosAusAktuellemAlbum.Count > 0); // wir wissen dass die DB immer 100 Alben zurückliefert
                Assert.IsFalse(mv.FotosAusAktuellemAlbum.Any(x => x.AlbumId != mv.CurrentSelectedAlbum.Id)); // Es darf kein Foto aus einem falschen Album vorhanden sein ...

            }
        }


    }
}
