import unittest
from selenium import webdriver
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.desired_capabilities import DesiredCapabilities
import time

class SeleniumTag(unittest.TestCase):

    desired_cap = {
        'browser': 'Chrome',
        'browser_version': '70.0',
        'os': 'Windows',
        'os_version': '10',
        'resolution': '1920x1080'
    }

    driver = webdriver.Remote(
        command_executor='http://yoni27:nrA3qNRqvEHGyEow7LjD@hub.browserstack.com:80/wd/hub',
        desired_capabilities=desired_cap)

    @classmethod
    def setUpClass(cls):
        cls.driver.maximize_window()
        cls.driver.implicitly_wait(10)
        cls.driver.get("http://atidcollege.co.il/selenium-tag/")

    @classmethod
    def tearDownClass(cls):
        time.sleep(10)
        cls.driver.quit()
        
    def test(self):
        




