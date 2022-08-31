* {
  margin: 0;
  padding: 0;
  font-family: "Poppins", sans-serif;
}
.header {
  min-height: 100vh;
  width: 100%;
  background-image: linear-gradient(rgba(4, 9, 30, 0.7), rgba(4, 9, 30, 0.7)), url(images/city.jpg);
  background-position: center;
  background-size: cover;
  position: relative;
}
nav {
  display: flex;
  padding: 2% 6%;
  justify-content: space-between;
  align-items: center;
}
nav .img {
  width: 150px;
}
.nav-links {
  flex: 1;
  text-align: right;
}
.nav-links ul li {
  list-style: none;
  display: inline-block;
  padding: 8px 12px;
  position: relative;
}
.nav-links ul li a {
  color: white;
  text-decoration: none;
  font-size: 14px;
}
.nav-links ul li::after {
  content: "";
  width: 0%;
  height: 2px;
  display: block;
  margin: auto;
  background: #fdf186;
  transition: 0.5s;
}
.nav-links ul li:hover::after {
  width: 100%;
}
.textbox {
  width: 90%;
  color: white;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  text-align: center;
}
.textbox h1 {
  font-size: 3rem;
}
.textbox p {
  margin: 10px 0 40px;
  font-size: 14px;
  color: aliceblue;
}
.main-cta {
  display: inline-block;
  text-decoration: none;
  color: black;
  border: 1px solid white;
  padding: 12px 34px;
  font-size: 14px;
  background: white;
  position: relative;
  cursor: pointer;
  font-weight: bold;
}
.main-cta:hover {
  background: transparent;
  transition: 1s;
  color: white;
}
.secondary-cta {
  display: inline-block;
  text-decoration: none;
  color: black;
  border: 1.5px solid #fdf186;
  padding: 12px 34px;
  margin-top: 40px;
  font-size: 14px;
  background: #fdf186;
  position: relative;
  cursor: pointer;
  font-weight: bold;
  border-radius: 1rem;
  opacity: 1;
}
.secondary-cta:hover {
  background: transparent;
  transition: 1s;
  opacity: 0.6;
  color: #d8c730;
}
nav .fa-solid {
  display: none;
}
@media (max-width: 700px) {
  .textbox h1 {
    font-size: 1rem;
  }
  .nav-links ul li {
    display: block;
  }
  .nav-links {
    position: absolute;
    background: linear-gradient(145deg, #001099 0, #3ad9ff 96%);
    height: 100vh;
    width: 200px;
    top: 0;
    right: -200px;
    text-align: left;
    z-index: 2;
    transition: 1s;
  }
  nav .fa-solid {
    display: block;
    color: white;
    margin: 10px;
    font-size: 22px;
    cursor: pointer;
  }
  .nav-links ul {
    padding: 30px;
  }
}
.what-we-do {
  width: 75%;
  margin: auto;
  text-align: center;
  padding-top: 100px;
}
.what-we-do h1 {
  font-size: 2em;
  font-weight: 700;
  padding-bottom: 40px;
}
.what-we-do p {
  width: 60%;
  margin: auto;
  color: black;
  font-size: 16px;
  font-weight: 300;
  line-height: 22px;
  padding: 10px;
  text-align: center;
}
.row {
  margin-top: 5%;
  display: flex;
  justify-content: space-between;
}
.what-we-do-col {
  flex-basis: 30%;
  border-radius: 10px;
  margin-bottom: 5%;
  padding: 20px 12px;
  box-sizing: border-box;
  color: black;
  background: #f6f6f4;
  transition: 1s;
}
.what-we-do-col p {
  color: black;
  width: 90%;
  margin: auto;
}
.what-we-do-col:hover {
  box-shadow: 0 0 20px 0px rgba(0, 0, 0, 0.4);
}
h3 {
  text-align: center;
  font-weight: 700;
  margin: 10px 0;
}
@media (max-width: 700px) {
  .row {
    flex-direction: column;
  }
}
/*--Portfolio--*/
.portfolio {
  width: 75%;
  margin: auto;
  text-align: center;
  padding-top: 90px;
}
.portfolio h1 {
  font-size: 2em;
  font-weight: 700;
  padding-bottom: 40px;
}
.portfolio p {
  width: 60%;
  margin: auto;
  color: black;
  font-size: 16px;
  font-weight: 300;
  line-height: 22px;
  padding: 10px;
  text-align: center;
}
.portfolio .portfolio-col {
  flex-basis: 32%;
  margin-bottom: 30px;
  position: relative;
  overflow: hidden;
}
.portfolio .portfolio-col img {
  width: 100%;
  transition: 0.5s;
  display: block;
}
.portfolio .portfolio-col h3 {
  width: 100%;
  font-weight: 700;
  color: #000;
  font-size: 30px;
  opacity: 0;
  transition: 0.5s;
}
.portfolio .portfolio-col:hover h3 {
  bottom: 49%;
  opacity: 1;
}
.layer {
  background: transparent;
  height: 100%;
  width: 100%;
  position: absolute;
  top: 0;
  left: 0;
  transition: 0.5s;
}
.layer:hover {
  background: linear-gradient(180deg, rgba(0, 0, 0, 0.25) -26.51%, rgba(196, 196, 196, 0) 100%);
}
/*--Pricing--*/
.pricing {
  width: 80%;
  margin: auto;
  text-align: center;
  padding-top: 100px;
}
.pricing h1 {
  font-size: 3em;
  font-weight: 700;
  padding-bottom: 40px;
}
.pricing h1 span {
  color: #001099;
}
.pricing #main {
  width: 70%;
  margin: auto;
  color: black;
  font-size: 16px;
  font-weight: 300;
  line-height: 22px;
  padding: 10px;
  text-align: center;
}
.pricing h2 {
  font-size: 32px;
  padding: 50px 0;
  text-align: center;
}
.pricing .row {
  width: 90%;
  margin: auto;
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  grid-gap: 8px;
}
.pricing-col {
  background: #d7d7d5;
  padding: 10% 15%;
  border-radius: 10px;
  color: black;
}
.pricing-col #secondary {
  font-size: 18px;
  text-transform: uppercase;
}
.pricing-col h3 {
  font-size: 44px;
  margin: 20px 0 40px;
  font-weight: 400;
  color: #001099;
}
.pricing-col h3 span {
  font-size: 16px;
}
.pricing-col ul {
  text-align: left;
  margin: 20px 0;
  color: #1f283b;
  list-style: none;
}
.pricing-col ul li {
  margin: 15px 0;
}
.pricing-col ul li::before {
  content: "\2022";
  color: #001099;
  font-weight: bold;
  margin-right: 8px;
}
.pricing-col button {
  width: 100%;
  padding: 14px 0;
  background: transparent;
  color: black;
  font-size: 15px;
  border: 2px solid black;
  border-radius: 6px;
  text-transform: uppercase;
  margin-top: 50px;
  cursor: pointer;
  transition: 0.5s;
}
.pricing-col button:hover {
  background: #fdf186;
}
.pricing-col-reco {
  background: #d7d7d5;
  padding: 10% 15%;
  border-radius: 10px;
  color: black;
  box-shadow: rgba(0, 0, 0, 0.09) 0px 2px 1px, rgba(0, 0, 0, 0.09) 0px 4px 2px, rgba(0, 0, 0, 0.09) 0px 8px 4px, rgba(0, 0, 0, 0.09) 0px 16px 8px, rgba(0, 0, 0, 0.09) 0px 32px 16px;
}
.pricing-col-reco p {
  font-size: 18px;
  text-transform: uppercase;
}
.pricing-col-reco #promo {
  font-size: 1em;
  color: black;
  left: -17px;
  z-index: 1000;
  margin: 0;
  padding: 0.625em 17px 0.75em;
  background: #a7ffa4;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.25);
  border-bottom: 1px solid #72fb6d;
}
.pricing-col-reco h3 {
  font-size: 44px;
  margin: 20px 0 40px;
  font-weight: 400;
  color: #001099;
}
.pricing-col-reco h3 span {
  font-size: 16px;
}
.pricing-col-reco ul {
  text-align: left;
  margin: 20px 0;
  color: #1f283b;
  list-style: none;
}
.pricing-col-reco ul li {
  margin: 15px 0;
}
.pricing-col-reco ul li::before {
  content: "\2022";
  color: #001099;
  font-weight: bold;
  margin-right: 8px;
}
.pricing-col-reco button {
  width: 100%;
  padding: 14px 0;
  background: transparent;
  color: black;
  font-size: 15px;
  border: 2px solid black;
  border-radius: 6px;
  margin-top: 50px;
  text-transform: uppercase;
  cursor: pointer;
  transition: 0.5s;
}
.pricing-col-reco button:hover {
  background: #fdf186;
}
/*--Call To Action-*/
.call-ta {
  margin: 100px auto;
  width: 80%;
  background-image: linear-gradient(rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7)), url(images/banner.jpg);
  background-position: center;
  background-size: cover;
  border-radius: 10px;
  text-align: center;
  padding: 100px 0;
}
.call-ta h1 {
  color: #fff;
  margin-bottom: 40px;
  padding: 0;
}
@media (max-width: 700px) {
  .call-ta h1 {
    font-size: 24px;
  }
}
/*----Footer---*/
.footer {
  width: 100%;
  text-align: center;
  padding: 30px 0;
}
.footer h4 {
  margin-top: 20px;
}
