package ru.itis.test.winium.tests;

import org.junit.Assert;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.remote.RemoteWebDriver;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;

public class TestCalc {
    @Test
    public void test() throws InterruptedException, IOException {
        ProcessBuilder pro = new ProcessBuilder("C:\\Users\\Гульназ\\Downloads\\Winium.Desktop.Driver\\Winium.Desktop.Driver.exe");
        Process shell = pro.start();
        DesiredCapabilities cap = new DesiredCapabilities();
        cap.setCapability("app","C:\\Windows\\system32\\notepad.exe"); //если хотим сразу запускать какую-либо программу
        cap.setCapability("launchDelay","5"); //задержка после запуска программы
        WebDriver driver = new RemoteWebDriver(new URL("http://localhost:9999"),cap); //на этом порту по умолчанию висит Winium драйвер
        String string = "Hello hey hi";
        driver.findElement(By.id("15")).click();
        driver.findElement(By.id("15")).sendKeys(string);
        Assert.assertEquals(string, driver.findElement(By.id("15")).getText());
        driver.findElement(By.id("Close")).click();
        driver.findElement(By.id("Close")).submit();
        shell.destroy();
    }
}
