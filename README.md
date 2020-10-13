# TemplConverters

TempleConverters is a Class Library containing common Value Converters for use in Xamarin.Forms projects. 

Common converters contained in this package include:
* InverseBoolConverter
* NumberEqualToZeroConverter
* NumberGreaterThanOrEqualToZeroConverter
* NumberGreaterThanZeroConverter
* NumberLessThanOrEqualToZeroConverter
* NumberLessThanOrZeroConverter
* StringIsNullOrEmptyToBoolConverter
* StringLengthEqualsIntConverter
* StringLengthGreaterThanIntConverter
* StringLengthGreaterThanOrEqualToIntConverter
* StringLengthLessThanIntConverter
* StringLengthLessThanOrEqualToIntConverter
* StringsMatchConverter


# Installation

To add the library to your Xamarin.Forms project, you can use NuGet with the following package:
	
~~~~
PM> Install-Package TemplConverters
~~~~

You should only have to install the package to your shared codebase project (e.g. `YourProject.Shared`).

# Usage

Once you have the Nuget package installed, you can reference it in your XAML pages by adding the following code at the top of the `.xaml` page:

~~~~
xmlns:converters="clr-namespace:Templ.Converters;assembly=Templ.Converters" 
~~~~

Add a ResourceDictionary to the page that contains a reference to the Converter you wish to use:

~~~~
<ContentPage.Resources>
        <ResourceDictionary>
            <converters:StringIsNullOrEmptyToBoolConverter x:Key="StringIsNullOrEmpty/>
        </ResourceDictionary>
</ContentPage.Resources>
~~~~

You can now reference the Converter resource in a XAML control like this:
~~~~
<Label Text="{Binding Message}"
       IsVisible="{Binding Message, Converter={StaticResource StringIsNullOrEmpty}}"/>
~~~~

If you want to be able to reference Converters from the library in any page in your project, simply add the reference to your App.xaml page like so:

~~~~
<?xml version="1.0" encoding="utf-8" ?>
<Application xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             xmlns:converters="clr-namespace:Templ.Converters;assembly=Templ.Converters" 
             mc:Ignorable="d"
             x:Class="YourProject.App">
    <Application.Resources>
        <ResourceDictionary>
            <converters:InverseBoolConverter x:Key="InverseBool" />
            <converters:StringIsNullOrEmptyToBoolConverter x:Key="StringIsNullOrEmpty" />
        </ResourceDictionary>
    </Application.Resources>
</Application>
~~~~
