using UnityEngine;

namespace ScriptableFramework.Variables
{
    public class VariableBase<T> : ScriptableObject
    {
        [Multiline]
        public string DeveloperDescription = "";
        public T Value;

        public void SetValue(T value)
        {
            Value = value;
        }

        public void SetValue(VariableBase<T> value)
        {
            Value = value.Value;
        }

        public void OnEnable()
        {
            //Debug.Log(this.Value);
        }
    }
}