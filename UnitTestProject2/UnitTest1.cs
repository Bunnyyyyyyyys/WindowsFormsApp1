using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace UnitTestProject
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestButton1Click_AddsItemToListBox2()
        {
            // Создаем экземпляр формы Form1
            Form1 testForm = new Form1();

            // Устанавливаем значения для listBox1 и comboBox1
            testForm.listBox1.Items.Add("Item 1");
            testForm.comboBox1.Items.Add("Option 1");
            testForm.listBox1.SelectedItem = "Item 1";
            testForm.comboBox1.Text = "Option 1";

            // Вызываем метод button1_Click через созданный экземпляр формы
            testForm.button1_Click(null, null);

            // Проверяем, что элемент был добавлен в listBox2
            Assert.IsTrue(testForm.listBox2.Items.Contains("Item 1: Option 1"), "Элемент не был добавлен в listBox2");
        }
    }
}

