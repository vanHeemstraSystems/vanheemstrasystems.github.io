# calculator.test.py

import unittest

    from calculator import Calculator
        
    class CalculatorTestCase(unittest.TestCase):
        def setUp(self):
            self.calculator = Calculator()
        
        def test_message(self):
            self.assertEqual(self.calculator.message, 'Hello World!', msg='Message Invalid.')