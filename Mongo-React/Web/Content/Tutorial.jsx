
    // All the components you'd like to render server-side
    //dropdown: require('react-dropdown') 
var EmployeeGridRow = React.createClass({

    render: function () {


        return (
                
           <tr>
                <td> {this.props.item.FirstName} </td>
                <td> {this.props.item.LastName} </td>
           </tr>



        );
    }
});

var EmployeeGridTable = React.createClass({
    getInitialState: function () {
        return {
            items: []
        }
    },
    componentDidMount: function(){
        $.ajax({
            url: "http://localhost:21136/Employee/Get",
            dataType: 'json',
            contentType: 'application/json',
            type: 'GET',
            success: function(data) {
                this.setState({items: data});
            }.bind(this)
        })
    },
    render: function () {
        var rows = [];
        this.state.items.forEach(function (item) {
            rows.push(
            <EmployeeGridRow item={item } />);
    });
return (
   <div>
<h2>List Employee</h2>
   <table className="table table-bordered table-responsive">
        <thead>
            <tr>
                <th>First Name</th>
                <th>Last Name</th>
            </tr>
        </thead>
        <tbody>
            {rows}
        </tbody>
   </table>
   
   </div>);
        
}
});
ReactDOM.render(
<EmployeeGridTable />,
document.getElementById('content')

    );
