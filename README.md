# AutoDestroyText Script - Unity C# Example

This project demonstrates the use of MonoBehaviour lifecycle methods along with a timer to spawn and automatically destroy a GameObject after a certain period. The `AutoDestroyText` script updates a `TextMeshProUGUI` element with the remaining time until the object is destroyed.

## Topics Learned

- **MonoBehaviour Lifecycle**: Understanding how different Unity lifecycle methods work, such as:
  - `Awake()`
  - `OnEnable()`
  - `Update()`
- **Timers**: Implementing a timer that counts down from a specified time (`AutoDestroyTime`), updating the UI with the remaining time.
- **Destroying GameObjects**: Using `Destroy()` to remove a GameObject from the scene once the timer reaches zero.
- **TextMeshPro**: Using `TextMeshProUGUI` to display dynamic text in the Unity UI.
- **Component Management**: Using the `[RequireComponent(typeof(TextMeshProUGUI))]` attribute to ensure that the GameObject has the required component.

## How to Use

1. **Set Up in Unity**:
   - Create a new Unity project or use an existing one.
   - Attach the `AutoDestroyText` script to a GameObject that has a `TextMeshProUGUI` component.
   - Adjust the `AutoDestroyTime` variable to set how long the text remains before being destroyed.
   
2. **Customization**:
   - Modify the `AutoDestroyTime` to control how long the object stays in the scene.
   - You can attach this script to any GameObject with a `TextMeshProUGUI` component to automatically display and destroy text after the specified time.

## Conclusion

This script provides an example of how Unity's MonoBehaviour lifecycle methods can be used to manage timers, update UI elements, and destroy GameObjects. It demonstrates a basic, useful pattern for managing timed objects in Unity.
