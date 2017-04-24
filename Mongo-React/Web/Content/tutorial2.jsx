

var EmployeeGridRow = React.createClass({

    render: function () {
        return (
                <option value={this.props.item.Name}> {this.props.item.Name} </option>
        );
    }
});

var EmployeeGridRowonchange = React.createClass({

    render: function () {
        return (
               <p>  {this.props.item.Name}  </p>
        );
    }
});

var EmployeeGridTable = React.createClass({
    getInitialState: function () {
        return {
            items: [],
            companies: [],
            companyname: 'Apexia'
        }
    },
    componentDidMount: function(){
        $.ajax({
            url: "http://localhost:21136/Company/Get",
            dataType: 'json',
            contentType: 'application/json',
            type: 'GET',
            success: function(data) {
                this.setState({items: data});
            }.bind(this)
        })
    },
    handleChange(event) {
        var namechange = event.target.value ;
        this.setState({ companyname: namechange });
        $.ajax({
            url: "http://localhost:21136/Company/GetByCompanyName?companyname="+this.state.companyname,
            dataType: 'json',
            contentType: 'application/json',
            type: 'GET',
            success: function (data) {
                this.setState({ companies: data });
            }.bind(this)
        })
    },
    render: function () {
        var rows = [];
        var company = [];
        this.state.items.forEach(function (item) {
            rows.push(
            <EmployeeGridRow item={item } key={item._id}/>);
            });
        //this.state.companies.forEach(function (item) {
            
                company.push(
                    <EmployeeGridRowonchange item={this.state.companies} />);
            //});
return (
  <div>
<h2>List Company</h2>
  <select onChange={this.handleChange} value={this.state.companyname}>

      {rows}

  </select>
{company}
</div>);

}
});
ReactDOM.render(
<EmployeeGridTable/>,
document.getElementById('company')

   );