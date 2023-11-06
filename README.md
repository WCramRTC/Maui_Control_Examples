# Maui_Control_Examples

## Label:

```xml
<Label Text="This is a label"
       TextColor="Blue"
       FontSize="18"
       FontAttributes="Bold"
       HorizontalOptions="CenterAndExpand"
       VerticalOptions="CenterAndExpand" />
```

* TextColor: Sets the text color.
* FontSize: Sets the font size.
* FontAttributes: Sets font attributes (e.g., bold).
* HorizontalOptions and VerticalOptions: Control the alignment of the label within its layout.

## TextBox (Entry):

```xml
<Entry Placeholder="Enter text here"
       TextColor="Black"
       FontSize="16"
       Keyboard="Text"
       HorizontalOptions="FillAndExpand" />
```

Placeholder: Sets the placeholder text.
TextColor: Sets the text color.
FontSize: Sets the font size.
Keyboard: Specifies the keyboard type for input.
HorizontalOptions: Controls the width of the text entry.

## Button:

```xml
<Button Text="Click me"
        TextColor="White"
        BackgroundColor="Blue"
        FontSize="16"
        Command="{Binding MyCommand}" />
```

* Text: Sets the button text.
* TextColor: Sets the text color.
* BackgroundColor: Sets the background color.
* FontSize: Sets the font size.
* Command: Assigns a command to execute when the button is clicked.

## Rich Text Box (Editor):

```xml
<Editor Placeholder="Type rich text here"
        TextColor="Black"
        FontSize="16"
        Keyboard="Chat"
        HorizontalOptions="FillAndExpand"
        VerticalOptions="FillAndExpand" />
```

* Placeholder: Sets the placeholder text.
* TextColor: Sets the text color.
* FontSize: Sets the font size.
* Keyboard: Specifies the keyboard type for input.
* HorizontalOptions and VerticalOptions: Control the size and alignment of the editor.

## CheckBox:

```xml
<CheckBox IsChecked="true"
          Color="Green"
          IsEnabled="true"
          AutomationProperties.Name="MyCheckBox" />
```
* IsChecked: Sets the initial checked state.
* Color: Sets the checkbox color.
* IsEnabled: Controls whether the checkbox is interactive.
* AutomationProperties.Name: Provides an accessible label.

## RadioButton:

```xml
<StackLayout>
    <RadioButton Content="Option 1"
                 TextColor="Black"
                 IsChecked="true" />
    <RadioButton Content="Option 2"
                 TextColor="Black" />
</StackLayout>
```
* Content: Sets the radio button label.
* TextColor: Sets the text color of the label.
* IsChecked: Sets the initial selection state.

## ListBox (ListView):

```xml
<ListView>
    <ListView.ItemsSource>
        <x:String>Item 1</x:String>
        <x:String>Item 2</x:String>
        <x:String>Item 3</x:String>
    </ListView.ItemsSource>
    <ListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <Label Text="{Binding}" />
            </ViewCell>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```
* ItemsSource: Binds the ListView to a collection of items.
* ItemTemplate: Defines how each item should be displayed.

## ComboBox (Picker):

```xml
<Picker Title="Select an option"
        SelectedIndex="0"
        TitleColor="Gray">
    <Picker.ItemsSource>
        <x:String>Option 1</x:String>
        <x:String>Option 2</x:String>
        <x:String>Option 3</x:String>
    </Picker.ItemsSource>
</Picker>
```

* Title: Sets the title (default text when nothing is selected).
* SelectedIndex: Specifies the initially selected item.
* TitleColor: Sets the title color.
* ItemsSource: Defines the list of options.
