package com.company;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.remote.RemoteWebDriver;

import java.net.MalformedURLException;
import java.net.URL;

public class Main {

    public static void main(String[] args) {
        DesiredCapabilities cap = new DesiredCapabilities();
        cap.setCapability("app","C:\\Windows\\System32\\calc.exe"); //если хотим сразу запускать какую-либо программу
        cap.setCapability("launchDelay","5"); //задержка после запуска программы
        try {
            WebDriver driver = new RemoteWebDriver(new URL("http://localhost:9999"),cap); //на этом порту по умолчанию висит Winium драйвер
        } catch (MalformedURLException e) {
            e.printStackTrace();
        }
    }
}
