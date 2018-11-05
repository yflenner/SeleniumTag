import java.util.concurrent.TimeUnit;
import org.openqa.selenium.By;
import org.openqa.selenium.Platform;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.remote.RemoteWebDriver;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;

import java.net.MalformedURLException;
import java.net.URL;

public class SeleniumTag
{
	WebDriver driver;
	DesiredCapabilities caps;
	public final String USERNAME = "yoni27";
	public final String AUTOMATE_KEY = "nrA3qNRqvEHGyEow7LjD";
	public final String URL = "https://" + USERNAME + ":" + AUTOMATE_KEY + "@hub-cloud.browserstack.com/wd/hub";

	@BeforeClass
	public void openBrowser() throws MalformedURLException
	{	
		caps = new DesiredCapabilities();
		caps.setCapability("browser", "Chrome");
		caps.setCapability("browser_version", "70.0");
		caps.setCapability("os", "Windows");
		caps.setCapability("os_version", "7");
		caps.setCapability("resolution", "1920x1080");
		driver = new RemoteWebDriver(new URL(URL), caps);

		driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		driver.manage().window().maximize();		
		driver.get("http://atidcollege.co.il/selenium-tag/");
	}

	@AfterClass
	public void closeBrowser() throws InterruptedException
	{
		Thread.sleep(10000);
		driver.quit();
	}

	@Test
	public void test1()
	{	
		
	}
}
