using UnityEngine;

public class EnvironmentInstaller : MonoBehaviour
{
   [SerializeField] private Light _lightPrefab;
   
   public Environment Install()
   {
      return CreateEnvironment();
   }

   private Environment CreateEnvironment()
   {
      var light = Instantiate(_lightPrefab);

      var environment = new Environment(light);

      return environment;
   }
}
