<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/Kabindas/microsvc">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Microservices Sharing Domain Objects</h3>

  <p align="center">
    How to share domain objects within a Microservices architecture !
    <br />
    ·
    <a href="https://github.com/Kabindas/microsvc/issues">Report Bug</a>
    ·
    <a href="https://github.com/Kabindas/microsvc/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

In a traditional microservices architecture, each entity has its own database. In the event that you need to show data that belong to two different entities, you will need to create an architecture that allows you to do so. This is just one way to do it 

<p align="right">(<a href="#top">back to top</a>)</p>

### Built With

List of frameworks/libraries used.

* [.Net Core](https://dotnet.microsoft.com/en-us/download)
* [Moq](https://www.nuget.org/packages/Moq/)
* [Fop](https://www.nuget.org/packages/Fop/)
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/13.0.1?_src=template)
* [Swashbuckle](https://www.nuget.org/packages/Swashbuckle.AspNetCore/6.3.0?_src=template)
* [Best-README-Template](https://github.com/othneildrew/Best-README-Template)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._

1. Clone the repo
   ```sh
   git clone https://github.com/Kabindas/microsvc.git
   ```
   
<p align="right">(<a href="#top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
## Usage

Feel free to use Visual Studio Code to run the project.
To run MSTests we advise to use Microsoft Visual Studio

Change <b>appsettings.json</b> to configure the path for the built-in sqlite databases<br>
Change <b>both dbContext.json</b> to configure the path for the built-in sqlite databases

When running the app the https://localhost:5001/swagger/ will provide access 

All migrations have already run, and all the MSTests are expecting the data sedded

There are two migrations, one for each database, to play with this there is a <b><i>util.txt</i></b> at microsvc.services/DbRepos with some commands to run on Package Manager Console.

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Vitor Correia <i>aka</i> Kabindas - vitormiguelcorreia@gmail.com

Project Link: [https://github.com/Kabindas/microsvc](https://github.com/Kabindas/microsvc)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/Kabindas/microsvc.svg?style=for-the-badge
[contributors-url]: https://github.com/Kabindas/microsvc/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Kabindas/microsvc.svg?style=for-the-badge
[forks-url]: https://github.com/Kabindas/microsvc/network/members
[stars-shield]: https://img.shields.io/github/stars/Kabindas/microsvc.svg?style=for-the-badge
[stars-url]: https://github.com/Kabindas/microsvc/stargazers
[issues-shield]: https://img.shields.io/github/issues/Kabindas/microsvc.svg?style=for-the-badge
[issues-url]: https://github.com/Kabindas/microsvc/issues
[license-shield]: https://img.shields.io/github/license/Kabindas/microsvc.svg?style=for-the-badge
[license-url]: https://github.com/Kabindas/microsvc/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
