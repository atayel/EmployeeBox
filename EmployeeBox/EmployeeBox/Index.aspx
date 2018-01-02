<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EmployeeBox.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-12">
                            <!--Top header start-->
                            <h3 class="ls-top-header">Dashboard</h3>
                            <!--Top header end -->

                            <!--Top breadcrumb start -->
                            <ol class="breadcrumb">
                                <li><a href="#"><i class="fa fa-home"></i></a></li>
                                <li class="active">Dashboard</li>
                            </ol>
                            <!--Top breadcrumb start -->
                        </div>
                    </div>
                    <!-- Main Content Element  Start-->
                    <div class="row">
                        <div class="col-md-9">
                            <div class="memberBox">
                                <div class="memberBox-header">
                                    <h5>Logged In Member</h5>
                                </div>
                                <div id="realTimeChart" class="flotChartRealTime widgetRealTime">
                                </div>
                                <div class="memberBox-details">
                                    <ul>
                                        <li>
                                            <div class="memberBox-title">
                                                <i class="fa fa-users"></i>
                                                <h4>Member</h4>
                                            </div>
                                            <div class="memberBox-value up"><i class="fa fa-user"></i><span>4250</span></div>
                                        </li>
                                        <li>
                                            <div class="memberBox-title">
                                                <i class="fa fa-eye"></i>
                                                <h4>Visitor</h4>
                                            </div>
                                            <div class="memberBox-value down"><i class="fa fa-flag"></i><span>9050</span></div>
                                        </li>
                                        <li>
                                            <div class="memberBox-title">
                                                <i class="fa fa-shopping-cart"></i>
                                                <h4>Sales</h4>
                                            </div>
                                            <div class="memberBox-value up"><i class="fa  fa-money"></i><span>50250</span></div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="current-status-widget">
                                <ul>
                                    <li>
                                        <div class="status-box">
                                            <div class="status-box-icon label-light-green white">
                                                <i class="fa fa-shopping-cart"></i>
                                            </div>
                                        </div>
                                        <div class="status-box-content">
                                            <h5 id="sale-view">2129</h5>
                                            <p class="lightGreen"><i class="fa fa-arrow-up lightGreen"></i>Total sold</p>
                                        </div>
                                        <div class="clearfix"></div>
                                    </li>
                                    <li>
                                        <div class="status-box">
                                            <div class="status-box-icon label-red white">
                                                <i class="fa fa-download"></i>
                                            </div>
                                        </div>
                                        <div class="status-box-content">
                                            <h5 id="download-show">5340</h5>
                                            <p class="light-blue"><i class="fa fa-arrow-down light-blue"></i>Total download</p>
                                        </div>
                                        <div class="clearfix"></div>
                                    </li>
                                    <li>
                                        <div class="status-box">
                                            <div class="status-box-icon label-lightBlue white">
                                                <i class="fa fa-truck"></i>
                                            </div>
                                        </div>
                                        <div class="status-box-content">
                                            <h5 id="deliver-show">10490</h5>
                                            <p class="light-blue"><i class="fa fa-arrow-up light-blue"></i>Product delivered</p>
                                        </div>
                                        <div class="clearfix"></div>
                                    </li>
                                    <li>
                                        <div class="status-box">
                                            <div class="status-box-icon label-light-green white">
                                                <i class="fa fa-users"></i>
                                            </div>
                                        </div>
                                        <div class="status-box-content">
                                            <h5 id="user-show">132129</h5>
                                            <p class="lightGreen"><i class="fa fa-arrow-up lightGreen"></i>Total users</p>
                                        </div>
                                        <div class="clearfix"></div>
                                    </li>
                                    <li>
                                        <div class="status-box">
                                            <div class="status-box-icon label-success white">
                                                <i class="fa fa-github"></i>
                                            </div>
                                        </div>
                                        <div class="status-box-content">
                                            <h5 id="product-up">29</h5>
                                            <p class="text-success"><i class="fa fa-arrow-up text-success"></i>Uploaded project</p>
                                        </div>
                                        <div class="clearfix"></div>
                                    </li>
                                    <li>
                                        <div class="status-box">
                                            <div class="status-box-icon label-light-green white">
                                                <i class="fa fa-dollar"></i>
                                            </div>
                                        </div>
                                        <div class="status-box-content">
                                            <h5 id="income-show">10299 </h5>
                                            <p class="lightGreen"><i class="fa fa-arrow-up lightGreen"></i>Total income</p>
                                        </div>
                                        <div class="clearfix"></div>
                                    </li>
                                </ul>
                            </div>

                        </div>
                    </div>

                    <div class="row home-row-top">
                        <div class="col-md-3 col-sm-3 col-xs-6 col-lg-3">
                            <div class="pie-widget">
                                <div id="pie-widget-1" class="chart-pie-widget" data-percent="73">
                                    <span class="pie-widget-count-1 pie-widget-count"></span>
                                </div>
                                <p>
                                    New Projects

                                </p>
                                <h5><i class="fa fa-bomb"></i>240 </h5>

                            </div>
                        </div>
                        <div class="col-md-3 col-sm-3 col-xs-6 col-lg-3">
                            <div class="pie-widget">
                                <div id="pie-widget-2" class="chart-pie-widget" data-percent="93">
                                    <span class="pie-widget-count-2 pie-widget-count"></span>
                                </div>
                                <p>
                                    New Users

                                </p>
                                <h5><i class="fa fa-child"></i>1240 </h5>

                            </div>
                        </div>
                        <div class="col-md-3 col-sm-3 col-xs-6 col-lg-3">
                            <div class="pie-widget">
                                <div id="pie-widget-3" class="chart-pie-widget" data-percent="23">
                                    <span class="pie-widget-count-3 pie-widget-count"></span>
                                </div>
                                <p>
                                    Total income

                                </p>
                                <h5><i class="fa fa-dollar"></i>120,040.35 </h5>

                            </div>
                        </div>
                        <div class="col-md-3 col-sm-3 col-xs-6 col-lg-3">
                            <div class="pie-widget">
                                <div id="pie-widget-4" class="chart-pie-widget" data-percent="33">
                                    <span class="pie-widget-count-4 pie-widget-count"></span>
                                </div>
                                <p>
                                    Sale reports

                                </p>
                                <h5><i class="fa fa-file-excel-o"></i>40</h5>

                            </div>
                        </div>
                    </div>

                    <div class="row home-row-top">
                        <div class="col-md-6">
                            <div class="sale-widget">
                                <!-- Nav tabs -->
                                <ul class="nav nav-tabs icon-tab icon-tab-home nav-justified">


                                    <li><a href="#monthly" data-toggle="tab"><i class="fa fa-calendar-o"></i><span>Monthly</span></a></li>
                                    <li class="active"><a href="#yearly" data-toggle="tab"><i class="fa fa-dollar"></i><span>Yearly</span></a></li>
                                    <li><a href="#product" data-toggle="tab" data-identifier="heroDonut"><i class="fa fa-shopping-cart"></i><span>Product</span></a></li>
                                </ul>

                                <!-- Tab panes -->
                                <div class="tab-content">
                                    <div class="tab-pane fade" id="monthly">
                                        <h4>Monthly Sales Report</h4>
                                        <p>In 6 month</p>
                                        <div class="monthlySale">
                                            <ul>
                                                <li>
                                                    <div class="progress vertical bottom">
                                                        <div class="progress-bar ls-light-blue-progress six-sec-ease-in-out" role="progressbar" aria-valuetransitiongoal="25"></div>
                                                    </div>
                                                    <div class="monthName">
                                                        Jan

                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="progress vertical bottom">
                                                        <div class="progress-bar progress-bar-info six-sec-ease-in-out" role="progressbar" aria-valuetransitiongoal="40"></div>
                                                    </div>
                                                    <div class="monthName">
                                                        Feb

                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="progress vertical bottom">
                                                        <div class="progress-bar progress-bar-success six-sec-ease-in-out" role="progressbar" aria-valuetransitiongoal="60"></div>
                                                    </div>
                                                    <div class="monthName">
                                                        Mar

                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="progress vertical bottom">
                                                        <div class="progress-bar progress-bar-warning six-sec-ease-in-out" role="progressbar" aria-valuetransitiongoal="80"></div>
                                                    </div>
                                                    <div class="monthName">
                                                        Apr

                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="progress vertical bottom">
                                                        <div class="progress-bar progress-bar-danger six-sec-ease-in-out" role="progressbar" aria-valuetransitiongoal="95"></div>
                                                    </div>
                                                    <div class="monthName">
                                                        May

                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="progress vertical bottom">
                                                        <div class="progress-bar  six-sec-ease-in-out" role="progressbar" aria-valuetransitiongoal="15"></div>
                                                    </div>
                                                    <div class="monthName">
                                                        Jun

                                                    </div>
                                                </li>
                                            </ul>

                                        </div>
                                    </div>


                                    <div class="tab-pane fade in active" id="yearly">
                                        <div id="seriesToggleWidget" class="seriesToggleWidget"></div>
                                        <ul id="choicesWidget"></ul>
                                    </div>
                                    <div class="tab-pane fade" id="product">
                                        <div id="flotPieChart" class="flotPieChartWidget"></div>
                                    </div>

                                </div>
                                <!-- Tab End -->
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="v-map-widget">
                                <div class="v-map-overlay">
                                    <ul>
                                        <li><span class="user-status is-online"></span>Online</li>
                                        <li><span class="user-status is-idle"></span>Idle</li>
                                        <li><span class="user-status is-busy"></span>Busy</li>
                                        <li><span class="user-status is-offline"></span>Offline</li>
                                    </ul>
                                </div>
                                <h3 class="ls-header">User Status</h3>
                                <div id="world_map" class="world_map_home_widget">
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="row home-row-top">
                        <div class="col-md-12">
                            <!--Table Wrapper Start-->
                            <div class="table-responsive ls-table">
                                <table class="table table-bordered table-striped table-responsive">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Product</th>
                                            <th>Info</th>
                                            <th>Progress</th>
                                            <th>Status</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>1</td>
                                            <td>PSD Design</td>
                                            <td>Lorem ipsum dolor sit amet</td>
                                            <td class="ls-table-progress">
                                                <div class="progress progress-striped active">
                                                    <div class="progress-bar progress-bar-success" role="progressbar" aria-valuetransitiongoal="50"></div>
                                                </div>
                                            </td>
                                            <td><span class="label label-warning">Pending</span></td>
                                            <td>
                                                <button class="btn btn-xs btn-info"><i class="fa fa-eye"></i></button>
                                                <button class="btn btn-xs ls-light-green-btn"><i class="fa fa-pencil"></i></button>
                                                <button class="btn btn-xs ls-red-btn"><i class="fa fa-trash-o"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>2</td>
                                            <td>PSD</td>
                                            <td>Lorem ipsum dolor sit amet</td>
                                            <td class="ls-table-progress">
                                                <div class="progress progress-striped active">
                                                    <div class="progress-bar progress-bar-primary" role="progressbar" aria-valuetransitiongoal="90"></div>
                                                </div>
                                            </td>
                                            <td><span class="label label-light-green">On Way</span></td>
                                            <td>
                                                <button class="btn btn-xs btn-info"><i class="fa fa-eye"></i></button>
                                                <button class="btn btn-xs ls-light-green-btn"><i class="fa fa-pencil"></i></button>
                                                <button class="btn btn-xs ls-red-btn"><i class="fa fa-trash-o"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>3</td>
                                            <td>PSD Theme</td>
                                            <td>Lorem ipsum dolor sit amet</td>
                                            <td class="ls-table-progress">
                                                <div class="progress progress-striped active">
                                                    <div class="progress-bar progress-bar-info" role="progressbar" aria-valuetransitiongoal="80"></div>
                                                </div>
                                            </td>
                                            <td><span class="label label-warning">Pending</span></td>
                                            <td>
                                                <button class="btn btn-xs btn-info"><i class="fa fa-eye"></i></button>
                                                <button class="btn btn-xs ls-light-green-btn"><i class="fa fa-pencil"></i></button>
                                                <button class="btn btn-xs ls-red-btn"><i class="fa fa-trash-o"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>4</td>
                                            <td>Wordpress Theme</td>
                                            <td>Lorem ipsum dolor sit amet</td>

                                            <td class="ls-table-progress">
                                                <div class="progress progress-striped active">
                                                    <div class="progress-bar progress-bar-danger" role="progressbar" aria-valuetransitiongoal="80"></div>
                                                </div>
                                            </td>
                                            <td><span class="label label-red">Error</span></td>
                                            <td>
                                                <button class="btn btn-xs btn-info"><i class="fa fa-eye"></i></button>
                                                <button class="btn btn-xs ls-light-green-btn"><i class="fa fa-pencil"></i></button>
                                                <button class="btn btn-xs ls-red-btn"><i class="fa fa-trash-o"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>5</td>
                                            <td>HTML Template</td>
                                            <td>Lorem ipsum dolor sit amet</td>

                                            <td class="ls-table-progress">
                                                <div class="progress progress-striped active">
                                                    <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuetransitiongoal="70"></div>
                                                </div>
                                            </td>
                                            <td>
                                                <span class="label label-light-green">On Way</span>
                                            </td>
                                            <td>
                                                <button class="btn btn-xs btn-info"><i class="fa fa-eye"></i></button>
                                                <button class="btn btn-xs ls-light-green-btn"><i class="fa fa-pencil"></i></button>
                                                <button class="btn btn-xs ls-red-btn"><i class="fa fa-trash-o"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>6</td>
                                            <td>Plugin</td>
                                            <td>Lorem ipsum dolor sit amet</td>

                                            <td class="ls-table-progress">
                                                <div class="progress progress-striped active">
                                                    <div class="progress-bar progress-bar-success" role="progressbar" aria-valuetransitiongoal="90"></div>
                                                </div>
                                            </td>
                                            <td><span class="label label-success">Successfull</span></td>
                                            <td>
                                                <button class="btn btn-xs btn-info"><i class="fa fa-eye"></i></button>
                                                <button class="btn btn-xs ls-light-green-btn"><i class="fa fa-pencil"></i></button>
                                                <button class="btn btn-xs ls-red-btn"><i class="fa fa-trash-o"></i></button>
                                            </td>
                                        </tr>
                                    </tbody>

                                </table>
                            </div>
                            <!--Table Wrapper Finish-->
                        </div>
                    </div>

                    <div class="row home-row-top">
                        <div class="col-md-4 col-sm-6">
                            <div class="setting-widget">
                                <div class="setting-widget-header">
                                    <h5 class="ls-header">Setting Widget <i class="fa fa-cog"></i></h5>
                                </div>
                                <div class="setting-widget-box">
                                    <ul>
                                        <li>Make invisible

                                            <div class="setting-switch">
                                                <input class="switchCheckBox" type="checkbox" checked data-size="mini"
                                                    data-label-text="<span class='user-status is-online'></span>"
                                                    data-on-text="<span class='fa fa-check'></span>"
                                                    data-off-text="<span class='fa fa-times'></span>"
                                                    data-on-color="success" data-off-color="danger">
                                            </div>
                                        </li>
                                        <li>Self Destruct

                                            <div class="setting-switch">
                                                <input class="switchCheckBox" type="checkbox" checked data-size="mini"
                                                    data-label-text="<i class='fa fa-gear'></i>"
                                                    data-on-text="<i class='fa fa-check'></i>"
                                                    data-off-text="<span class='fa fa-times'></span>">
                                            </div>
                                        </li>

                                        <li>Currency

                                            <div class="setting-switch">
                                                <input class="switchCheckBox" type="checkbox" data-size="mini" checked
                                                    data-label-text="<span class='fa fa-money fa-lg'></span>"
                                                    data-on-text="<i class='fa fa-dollar'><i>"
                                                    data-off-text="<i class='fa fa-eur'><i>">
                                            </div>
                                        </li>
                                        <li>FireWall

                                            <div class="setting-switch">
                                                <input class="switchCheckBox" type="checkbox" data-size="mini"
                                                    data-label-text="<span class='fa fa-shield'></span>"
                                                    data-on-text="<i class='fa fa-check'><i>"
                                                    data-off-text="<i class='fa fa-times'><i>"
                                                    data-on-color="success" data-off-color="danger">
                                            </div>
                                        </li>
                                        <li>Change Color

                                            <div class="setting-switch">
                                                <div class="change-color-switch">
                                                    <ul>
                                                        <li class="default active"></li>
                                                        <li class="red-color"></li>
                                                        <li class="blue-color"></li>
                                                        <li class="light-green-color"></li>
                                                        <li class="black-color"></li>
                                                        <li class="deep-blue-color"></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </li>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6">
                            <div class="skyWeather label-light-green white">
                                <div class="current-weather">
                                    <div class="current-weather-icon">
                                        <canvas id="rain" width="128" height="128"></canvas>
                                    </div>
                                    <div class="current-weather-details">
                                        <h2>20°c</h2>
                                        <span>Heavy Rani</span>
                                        <p>24°c / 12°c</p>
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="feature-weather">
                                    <ul>
                                        <li>
                                            <a href="javascript:void(0)">
                                                <canvas id="clear-day" width="32" height="32"></canvas>
                                                <span>Sat</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a href="javascript:void(0)">
                                                <canvas id="clear-night" width="32" height="32"></canvas>
                                                <span>Sun</span>
                                            </a>

                                        </li>
                                        <li>
                                            <a href="javascript:void(0)">
                                                <canvas id="partly-cloudy-day" width="32" height="32"></canvas>
                                                <span>Mon</span>
                                            </a>

                                        </li>
                                        <li>
                                            <a href="javascript:void(0)">
                                                <canvas id="cloudy" width="32" height="32"></canvas>
                                                <span>Tue</span>
                                            </a>

                                        </li>
                                        <li>
                                            <a href="javascript:void(0)">
                                                <canvas id="fog" width="32" height="32"></canvas>
                                                <span>Wed</span>
                                            </a>

                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-4 col-sm-12">
                            <div class="social-share-box">
                                <div class="container-fluid">
                                    <div class="row">
                                        <div class="ls-fb-share social-share col-md-6 col-sm-3 col-xs-6">
                                            <i class="fa fa-facebook"></i>
                                            <div class="share-overlay">
                                                <a href="#" class="expand">4.2K</a>
                                                <a class="close-overlay hidden">x</a>
                                            </div>
                                        </div>
                                        <div class="ls-tw-share social-share col-md-6 col-sm-3 col-xs-6">
                                            <i class="fa fa-twitter"></i>
                                            <div class="share-overlay">
                                                <a href="#" class="expand">5.4K</a>
                                                <a class="close-overlay hidden">x</a>
                                            </div>
                                        </div>
                                        <div class="ls-google-plus social-share col-md-6 col-sm-3 col-xs-6">
                                            <i class="fa fa-google-plus"></i>
                                            <div class="share-overlay">
                                                <a href="#" class="expand">7.8K</a>
                                                <a class="close-overlay hidden">x</a>
                                            </div>
                                        </div>
                                        <div class="ls-dribble-plus social-share col-md-6 col-sm-3 col-xs-6">
                                            <i class="fa fa-dribbble"></i>
                                            <div class="share-overlay">
                                                <a href="#" class="expand">1.2K</a>
                                                <a class="close-overlay hidden">x</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Main Content Element  End-->

                </div>
</asp:Content>
