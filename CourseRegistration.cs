< Window x: Class = "EDUMORH.CourseRegistration" //course registration
        xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
        Title = "Course Registration" Height = "300" Width = "400" >
    < Grid >
        < Grid.ColumnDefinitions >
            < ColumnDefinition Width = "100" />
            < ColumnDefinition Width = "*" />
        </ Grid.ColumnDefinitions >

        < Grid.RowDefinitions >
            < RowDefinition Height = "30" />
            < RowDefinition Height = "30" />
            < RowDefinition Height = "*" />
            < RowDefinition Height = "50" />
        </ Grid.RowDefinitions >

        < Label Grid.Column = "0" Grid.Row = "0" Content = "Name:" />
        < TextBox Grid.Column = "1" Grid.Row = "0" Name = "nameTextBox" />

        < Label Grid.Column = "0" Grid.Row = "1" Content = "Email:" />
        < TextBox Grid.Column = "1" Grid.Row = "1" Name = "emailTextBox" />

        < Label Grid.Column = "0" Grid.Row = "2" Content = "Course:" />
        < ComboBox Grid.Column = "1" Grid.Row = "2" Name = "courseComboBox" />

        < Button Grid.Column = "1" Grid.Row = "3" Content = "Register" Name = "registerButton" Click = "RegisterButton_Click" />
    </ Grid >
</ Window >
