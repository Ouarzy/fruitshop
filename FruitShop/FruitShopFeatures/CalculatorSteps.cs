using FruitShop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class CalculatorSteps
    {

        public Calculator Calculator
        {
            get { return ScenarioContext.Current.Get<Calculator>("Calculator"); }
            set { ScenarioContext.Current.Set(value, "Calculator"); }
        }

        public int Sum
        {
            get { return ScenarioContext.Current.Get<int>("Sum"); }
            set { ScenarioContext.Current.Set(value, "Sum"); }
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Calculator = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int valueToAdd)
        {
            Calculator.Add(valueToAdd);
        }
        
        [When(@"A sum is requested")]
        public void WhenASumIsRequested()
        {
            Sum = Calculator.Sum();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int actualSum)
        {
            Assert.AreEqual(Sum, actualSum);
        }
    }
}
