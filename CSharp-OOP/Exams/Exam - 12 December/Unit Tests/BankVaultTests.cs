using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private Item item;
        private BankVault vault;

        [SetUp]
        public void Setup()
        {
            item = new Item("Orax", "231");
            vault = new BankVault();
        }

        [Test]
        public void TestItemCreation()
        {
            Assert.AreEqual("Orax", item.Owner);
            Assert.AreEqual("231", item.ItemId);
        }

        [Test]
        public void TestVaultCreation()
        {
            vault.VaultCells.ContainsKey("A1");
            vault.VaultCells.ContainsKey("A2");
            vault.VaultCells.ContainsKey("A3");
            vault.VaultCells.ContainsKey("A4");
            vault.VaultCells.ContainsKey("B1");
            vault.VaultCells.ContainsKey("B2");
            vault.VaultCells.ContainsKey("B3");
            vault.VaultCells.ContainsKey("B4");
            vault.VaultCells.ContainsKey("C1");
            vault.VaultCells.ContainsKey("C2");
            vault.VaultCells.ContainsKey("C3");
            vault.VaultCells.ContainsKey("C4");
            vault.VaultCells.ContainsKey("D1");
            vault.VaultCells.ContainsKey("D2");
            vault.VaultCells.ContainsKey("D3");
            vault.VaultCells.ContainsKey("D4");
        }

        [Test]
        public void TestVaultAddWrongCell()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("55", item);
            });
        }

        [Test]
        public void TestTakenCell()
        {
            var item2 = new Item("Me", "Toy");
            Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A1", item);
                vault.AddItem("A1", item2);
            });
        }


        [Test]
        public void TestExistingItem()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A1", item);
                vault.AddItem("A2", item);
            });
        }

        [Test]
        public void TestVaultRemoveFromWrongCell()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("55", item);
            });
        }

        [Test]
        public void TestVaultRemoveNonExistingItem()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A1", item);
            });
        }
    }
}