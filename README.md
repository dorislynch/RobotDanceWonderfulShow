
# react-native-robot-dance-wonderful-show

## Getting started

`$ npm install react-native-robot-dance-wonderful-show --save`

### Mostly automatic installation

`$ react-native link react-native-robot-dance-wonderful-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-robot-dance-wonderful-show` and add `RNRobotDanceWonderfulShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNRobotDanceWonderfulShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNRobotDanceWonderfulShowPackage;` to the imports at the top of the file
  - Add `new RNRobotDanceWonderfulShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-robot-dance-wonderful-show'
  	project(':react-native-robot-dance-wonderful-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-robot-dance-wonderful-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-robot-dance-wonderful-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNRobotDanceWonderfulShow.sln` in `node_modules/react-native-robot-dance-wonderful-show/windows/RNRobotDanceWonderfulShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Robot.Dance.Wonderful.Show.RNRobotDanceWonderfulShow;` to the usings at the top of the file
  - Add `new RNRobotDanceWonderfulShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNRobotDanceWonderfulShow from 'react-native-robot-dance-wonderful-show';

// TODO: What to do with the module?
RNRobotDanceWonderfulShow;
```
  