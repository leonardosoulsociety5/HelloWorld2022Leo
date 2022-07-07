using UnityEngine;
using UnityEngine.UI;

// This is a sample output file
public class OutputScript : MonoBehaviour {
  public Names names = new Names ();
  public Numbers numbers = new Numbers ();
  public string givenName = "Leonardo";
  public Text Out1;
  public Text Out2;
  public Text Out3;

  public InputField Op1;
  public InputField Op2;

  // Start is called before the first frame update and is used to set variables in this component (MonoBehaviour)
  void Start () {
    // REPLACE THIS WITH YOUR NAME.
    names.name = givenName;
    Out1.text = names.name;
    Out2.text = names.UseGreeting("Hello World from ");
  }

  public void CalculateSum () {
    int.TryParse (Op1.text, out int op1);
    int.TryParse (Op2.text, out int op2);
    Out3.text = numbers.SumTwoArguments (op1, op2).ToString ();
  }

  public void UseGreaterThan () {
    int.TryParse (Op1.text, out int op1);
    int.TryParse (Op2.text, out int op2);
    numbers.memberA = op1;
    numbers.memberB = op2;
    bool greaterThan = numbers.GreaterThan ();
    if (greaterThan) {
      Out3.text = Op1.text + " is greater than " + Op2.text;
    } else {
      Out3.text = Op1.text + " is less than " + Op2.text;
    }
  }
}