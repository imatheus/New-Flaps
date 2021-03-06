@import url("https://fonts.googleapis.com/css2?family=Mitr:wght@200&family=Nanum+Pen+Script&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Commissioner:wght@200&family=Tajawal&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Rubik:wght@500&display=swap");
@import url("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css");
* {
  margin: 0;
  text-decoration: none;
  list-style: none; }

html, body {
  width: 100%;
  height: 100%;
  background-color: #F7F7F7; }

.headerUp {
  position: absolute;
  margin: 10px;
  display: inline-flex;
  justify-content: space-between;
  align-items: center;
  margin-left: 5%;
  width: 10%; }
  @media only screen and (max-width: 600px) {
    .headerUp {
      width: 50%; } }
  .headerUp ul {
    display: inline-flex;
    margin-left: 25%;
    align-items: center; }
  .headerUp li {
    font-family: Commissioner;
    color: #fff;
    font-weight: 700;
    font-size: 1.1rem;
    margin: 10px;
    transition: 0.3s; }
  .headerUp li:hover {
    transition: all 0.1s;
    margin-top: -1px;
    -ms-zoom-animation: 1; }

@keyframes pulando {
  to {
    transform: translateY(30px); } }

h2 {
  font-size: 25px;
  font-weight: 800;
  font-family: Commissioner;
  color: #616161;
  text-align: center;
  margin: 10px; }

h3 {
  text-align: center;
  font-family: Commissioner;
  color: #ffffff;
  font-size: 18px;
  font-weight: 600;
  margin: 5px; }

h4 {
  font-size: 15px;
  font-family: Commissioner;
  color: #070707;
  text-align: center;
  margin: 1px; }

h5 {
  font-family: Commissioner;
  color: #b4b4b4;
  font-size: 15px;
  margin: 5px; }

p {
  font-family: Commissioner;
  color: #464545;
  font-size: 18px;
  margin: 5px; }

#setaUp {
  animation: pulando 1s ease-out alternate infinite;
  margin-top: -15%;
  display: flex;
  justify-content: center;
  align-items: center; }
  @media only screen and (max-width: 600px) {
    #setaUp {
      display: none; } }

.banner-info {
  position: absolute;
  top: 30%;
  left: 7%; }
  @media only screen and (max-width: 600px) {
    .banner-info {
      top: 15%; } }
  .banner-info h1 {
    font-size: 4rem;
    color: azure;
    font-family: Rubik;
    font-weight: 300; }
    @media only screen and (max-width: 600px) {
      .banner-info h1 {
        font-size: 2.5rem; } }
  .banner-info #orcamento {
    background: #c60aff linear-gradient(to right, #c60aff, #ff7b00);
    border-radius: 25px 25px 0px 25px;
    border: none;
    padding: 12px;
    width: 12rem;
    font-family: Arial, Helvetica, sans-serif;
    color: #fff;
    font-size: 1.1rem;
    cursor: pointer; }
  .banner-info #orcamento:hover {
    background: #c60aff; }

.bg-modal {
  width: 100%;
  height: 100%;
  background: rgba(2, 2, 2, 0.897);
  position: fixed;
  z-index: 2;
  left: -100%;
  display: block;
  transition: 150ms; }
  .bg-modal .modal {
    padding: 10px;
    margin: 40px auto 0 auto;
    width: 50%;
    height: 32rem;
    background: #fff;
    border-radius: 15px; }
    @media only screen and (max-width: 600px) {
      .bg-modal .modal {
        width: 90%; } }
    .bg-modal .modal .close {
      float: right;
      font-size: 26px;
      margin: 10px;
      color: #6303bd;
      transition: 350ms;
      cursor: pointer; }

.close:hover {
  color: #9000b4;
  transition: 350ms; }

.title-modal h3 {
  color: #6303bd; }

.tasks-modal {
  height: 90%;
  width: 100%; }
  .tasks-modal .services {
    align-items: center;
    justify-content: left;
    display: flex;
    padding: 10px;
    height: 50px;
    border-radius: 5px;
    background: #dddddd; }
    .tasks-modal .services h3 {
      color: #6303bd; }
    .tasks-modal .services fieldset {
      width: 50%; }
  .tasks-modal .design {
    align-items: center;
    justify-content: space-around;
    display: flex;
    padding: 10px;
    height: 50px;
    border-radius: 5px;
    background: #dddddd; }
    .tasks-modal .design h3 {
      color: #6303bd; }
    .tasks-modal .design fieldset {
      width: 58%;
      display: flex;
      border-radius: 5px;
      border: 1px #6303bd solid; }
    .tasks-modal .design input {
      border: 1px #6303bd solid;
      height: 25px;
      width: 16%; }
  .tasks-modal .prazo {
    align-items: center;
    justify-content: left;
    display: flex;
    height: 50px;
    padding: 10px;
    border-radius: 5px;
    background: #dddddd; }
    .tasks-modal .prazo h3 {
      color: #6303bd; }
    .tasks-modal .prazo fieldset {
      width: 59%;
      justify-content: left;
      display: flex; }
  .tasks-modal .name-email {
    align-items: center;
    justify-content: center;
    display: flex;
    height: 50px; }
    .tasks-modal .name-email input {
      border-radius: 7px;
      border: 1px #6303bd solid;
      width: 85%;
      font-size: 19px;
      padding: 10px;
      height: 30px;
      justify-content: left;
      display: flex; }
  .tasks-modal .btn {
    align-items: center;
    justify-content: center;
    display: flex;
    height: 50px;
    margin-top: 5%; }
    .tasks-modal .btn button {
      width: 35rem;
      height: 45px;
      border-radius: 25px;
      border: none;
      background: #ffbe0a linear-gradient(to right, #ffbe0a, #ff7b00);
      cursor: pointer;
      font-family: Commissioner;
      font-size: 19px;
      color: #fff; }
      @media only screen and (max-width: 600px) {
        .tasks-modal .btn button {
          width: 20rem; } }
    .tasks-modal .btn button:hover {
      border: #ffbe0a 1px solid;
      color: orange;
      transition: 0.5s;
      background: transparent; }

input[type="text"] {
  height: 20px;
  margin: -2px;
  margin-left: 2px;
  border-radius: 2px;
  border: none; }

input[type="checkbox"] {
  height: 20px;
  width: 30px; }

.hamburguer {
  height: 40px;
  width: 40px;
  position: fixed;
  z-index: 100;
  right: 2rem;
  top: 1rem;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
  cursor: pointer; }
  .hamburguer .line {
    border-radius: 10px;
    width: 100%;
    height: 6px;
    background: #fff;
    box-shadow: 0 0.1rem 1rem #6303bd; }

.sidebar {
  width: 20rem;
  height: 100vh;
  background: #fff;
  position: fixed;
  top: 0;
  right: -20rem; }
  .sidebar .show-menu {
    right: 0; }
  .sidebar .menu {
    position: absolute;
    justify-content: center;
    top: 20%;
    transform: translateY(50%) translateX(50%); }
    .sidebar .menu a li {
      margin-bottom: 8px;
      color: #6303bd;
      font-size: 1.5rem;
      text-align: center;
      font-family: Commissioner; }
  .sidebar .social-media {
    font-size: 30px;
    display: flex;
    justify-content: space-evenly;
    align-items: center;
    padding: 10px;
    position: absolute;
    bottom: 10rem;
    width: 100%; }

.full-banner {
  width: 100%;
  flex-wrap: wrap; }
  @media only screen and (max-width: 600px) {
    .full-banner {
      height: 55vh;
      background: #36014a;
      background: linear-gradient(90deg, #36014a 0%, #581aa2 35%, #a200ff 100%); }
      .full-banner img {
        display: none; } }
  .full-banner img {
    width: 100%; }

.container-servicos {
  flex-wrap: wrap;
  margin-top: 10%;
  margin-left: -2%; }
  .container-servicos button {
    width: 20rem;
    padding: 10px;
    border-radius: 25px;
    border: #d794fd 1px solid;
    cursor: pointer;
    font-family: Commissioner;
    font-size: 19px;
    font-weight: 600;
    color: #9d0aff;
    background: transparent; }
  .container-servicos button:hover {
    background: #ba04df linear-gradient(to right, #6303bd, #c804e2);
    color: #fff;
    transition: 0.5s;
    border: none;
    box-shadow: 0 0.1rem 1rem #6303bd; }

#ver-mais {
  font-family: arial;
  font-size: 17px;
  height: 30px;
  color: #6303bd;
  background: none;
  border: none;
  display: inline-flex;
  justify-content: center;
  padding: 20px;
  align-items: center; }

.container-servicos {
  text-align: center;
  justify-content: center; }
  .container-servicos .title-header {
    font-size: 23px;
    color: #8d8d8d;
    font-family: Commissioner;
    font-variant: inherit;
    font-weight: 200; }
  .container-servicos .grid {
    margin-top: 2%;
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
    width: 100%; }

.card-servico {
  box-shadow: 0 0.4rem 1rem #c5c5c5;
  margin-top: 10%;
  padding: 18px;
  width: 340px;
  margin: 15px;
  background-color: white;
  border-radius: 15px;
  text-align: center;
  transition: all 0.3s; }
  .card-servico img {
    justify-content: center;
    display: flex;
    border-radius: 7px;
    margin-top: 1rem;
    margin: -0.1rem; }
  .card-servico p {
    padding: 15px;
    text-align: left; }
  .card-servico button {
    width: 20rem;
    padding: 10px;
    border-radius: 25px;
    border: #d794fd 1px solid;
    cursor: pointer;
    font-family: Commissioner;
    font-size: 19px;
    font-weight: 600;
    color: #9d0aff;
    background: transparent; }
  .card-servico button:hover {
    background: #ba04df linear-gradient(to right, #6303bd, #c804e2);
    color: #fff;
    transition: 0.5s;
    border: none;
    box-shadow: 0 0.1rem 1rem #6303bd; }

.card-servico:hover {
  transition: all 0.5s;
  bottom: 10%;
  margin-top: -1%; }

.container-about {
  margin-top: 5%; }
  .container-about button {
    width: 150px;
    margin-top: 4%;
    height: 35px;
    border-radius: 20px;
    border: none;
    background: #c60aff linear-gradient(to right, #c60aff, #9b04a0);
    cursor: pointer;
    font-family: Commissioner;
    font-size: 19px;
    color: #fff; }
  .container-about button:hover {
    border: none;
    color: #fff;
    background: #b03af5d2;
    box-shadow: rgba(143, 24, 212, 0.824) ow; }
  .container-about .title-header {
    font-size: 23px;
    color: #8d8d8d;
    font-family: Commissioner;
    font-variant: inherit;
    font-weight: 200; }

.about {
  padding: 80px;
  flex-wrap: wrap;
  justify-content: space-around;
  display: flex;
  align-items: center;
  background: #F7F7F7; }
  @media only screen and (max-width: 600px) {
    .about img {
      width: 100%;
      height: 100%;
      padding: 10px; } }
  .about .about-right {
    background: #ff4f73;
    background: linear-gradient(90deg, #ff4f73 0%, rgba(255, 156, 126, 0.868785) 50%, rgba(252, 170, 69, 0.804359) 100%);
    padding: 50px;
    width: 90%;
    height: 300px;
    border-radius: 65px; }
    @media only screen and (max-width: 600px) {
      .about .about-right {
        display: none; } }
    .about .about-right p, .about .about-right h1 {
      text-align: left;
      color: #ffffff;
      padding: 10px; }
    .about .about-right img {
      margin-left: 45%;
      margin-top: -15%; }
      @media only screen and (max-width: 600px) {
        .about .about-right img {
          display: none; } }

.container-projetos {
  text-align: center;
  justify-content: center;
  align-items: center;
  display: grid;
  padding: 10rem;
  background-image: url("https://wallpaperset.com/w/full/3/3/e/434982.jpg");
  background-attachment: fixed;
  background-size: 100%;
  background-repeat: no-repeat; }
  @media only screen and (max-width: 600px) {
    .container-projetos {
      background-size: 250%;
      background-attachment: fixed; } }
  .container-projetos h1 {
    color: #f1f1f1; }
  .container-projetos .title-header {
    font-size: 23px;
    color: #8d8d8d;
    font-family: Commissioner;
    font-variant: inherit;
    font-weight: 200; }
  .container-projetos .grid {
    margin-top: 2%;
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
    width: 100%; }

.card-projetos {
  background-repeat: no-repeat;
  background-size: 600px;
  width: 330px;
  margin: 5px; }

#project1 {
  background-image: url("../imagens/projects/55.png");
  background-repeat: no-repeat;
  background-size: 700px;
  background-position: center; }

#project2 {
  background-image: url("../imagens/projects/56.jpg");
  background-repeat: no-repeat;
  background-size: 700px;
  background-position: center; }

#project3 {
  background-image: url("../imagens/projects/57.png");
  background-repeat: no-repeat;
  background-size: 700px;
  background-position: center; }

.card-projetos:hover {
  opacity: 0.9;
  transition: 0.5s; }

.card-info {
  visibility: hidden;
  margin-top: 70%;
  padding: 10px;
  color: #fff;
  cursor: pointer;
  bottom: 0;
  opacity: 0;
  transition: all 0.3s;
  text-align: center; }

.card-projetos:hover .card-info {
  visibility: visible;
  opacity: 1;
  margin-top: 60%;
  transition: all 0.5s;
  text-align: center; }

.card-info h3, p {
  text-align: center;
  margin: 6px; }

fieldset, #select-contato, textarea {
  border: none;
  padding: 10px;
  width: 90%; }

.container-contato {
  background: #4f0779; }
  @media only screen and (max-width: 600px) {
    .container-contato {
      width: 100%;
      height: 100%; } }

.card-contato {
  background-color: azure;
  width: 49%;
  height: 40%;
  float: right; }

.container-img-form img {
  float: left; }
  @media only screen and (max-width: 600px) {
    .container-img-form img {
      width: 100%; } }

#area-input input {
  width: 100%;
  height: 1.2rem;
  padding: 15px;
  background-color: #dbdada;
  margin: 1px;
  border-radius: 5px;
  border: #e2e2e2 1px solid;
  font-family: Commissioner;
  color: #6303bd;
  font-size: 17px; }

#select-contato {
  font-size: 20px;
  font-family: Commissioner;
  background: #7204a5 linear-gradient(to right, #6d03d1, #c804e2);
  color: white;
  padding: 5px;
  width: 108%;
  height: 48px;
  margin: 1px;
  border-radius: 5px;
  cursor: pointer; }

footer {
  margin-top: 300px;
  background-color: #505050; }

textarea {
  font-size: 1.2rem;
  position: static;
  background-color: #dbdada;
  font-family: Commissioner;
  max-height: 200px;
  max-width: 410px;
  width: 980px;
  height: 55px;
  padding: 10px;
  border-radius: 5px; }
  @media only screen and (max-width: 600px) {
    textarea {
      max-width: 250px; } }

/*# sourceMappingURL=style.css.map */
