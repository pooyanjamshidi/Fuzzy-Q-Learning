% This script analyze the data and prepare the simulation diagrams
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NO_REPLICATIONS ITERMAX NA NS TPM TRM LAMBDA

x=1:1:ITERMAX;
figure;
plot(x,squeeze(stat_h(1,1,:))',x,squeeze(stat_h(1,2,:))');

figure;
plot(x,squeeze(stat_h(2,1,:))',x,squeeze(stat_h(2,2,:))');

figure;
plot(x,squeeze(stat_h(3,1,:))',x,squeeze(stat_h(2,2,:))');
