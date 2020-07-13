using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using FootballManager.Domain.Entities;
using FootballManager.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertGameIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var game = new Game();
            context.Games.Add(game);
            Assert.AreEqual(EntityState.Added, context.Entry(game).State);
        }
    }
}
